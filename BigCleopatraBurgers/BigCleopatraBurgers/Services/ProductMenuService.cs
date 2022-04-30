using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BigCleopatraBurgers.Models;
using BigCleopatraBurgers.Repositories;

namespace BigCleopatraBurgers.Services
{
    public class ProductMenuService
    {
        private readonly IProductRepository productRepository;
        public ProductMenuService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await productRepository.GetProductsAsync();
        }
    }
}

