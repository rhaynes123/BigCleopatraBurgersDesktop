using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using BigCleopatraBurgers.Models;
using BigCleopatraBurgers.Repositories;
using BigCleopatraBurgers.Extensions;
using StackExchange.Redis;

namespace BigCleopatraBurgers.Services
{
    public class ProductMenuService
    {
        private readonly IProductRepository productRepository;
        private readonly IDistributedCache distributedCache;
        private readonly ILogger<ProductMenuService> logger;
        public ProductMenuService(IProductRepository productRepository
            , IDistributedCache distributedCache
            , ILogger<ProductMenuService> logger)
        {
            this.productRepository = productRepository;
            this.distributedCache = distributedCache;
            this.logger = logger;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            IEnumerable<Product> products;
            string key = $"{nameof(ProductMenuService)}_{DateTime.UtcNow.Hour}";
            try
            {
                products = await distributedCache.GetValuesAsync<IEnumerable<Product>>(keyId: key);
            }
            catch(RedisConnectionException ex)
            {
                logger.LogWarning($"Redis Cache Unavaliable: {ex.Message}");
                return await productRepository.GetProductsAsync();
            }
            
            if(products is null)
            {
                products = await productRepository.GetProductsAsync();
                await distributedCache.SetValuesAsync(keyId:key,data:products);
            }
            return products;
        }
    }
}

