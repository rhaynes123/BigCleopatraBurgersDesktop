using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using BigCleopatraBurgers.Models;
using BigCleopatraBurgers.Repositories;
using BigCleopatraBurgers.Extensions;

namespace BigCleopatraBurgers.Services
{
    public class ProductMenuService
    {
        private readonly IProductRepository productRepository;
        private readonly IDistributedCache distributedCache;
        public ProductMenuService(IProductRepository productRepository, IDistributedCache distributedCache)
        {
            this.productRepository = productRepository;
            this.distributedCache = distributedCache;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            IEnumerable<Product> products;
            string key = $"{nameof(ProductMenuService)}_{DateTime.UtcNow.Hour}";
            products = await distributedCache.GetValuesAsync<IEnumerable<Product>>(keyId: key);
            if(products is null)
            {
                products = await productRepository.GetProductsAsync();
                await distributedCache.SetValuesAsync(keyId:key,data:products);
            }
            return products;
        }
    }
}

