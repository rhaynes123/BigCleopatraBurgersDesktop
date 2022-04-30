using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigCleopatraBurgers.Data;
using BigCleopatraBurgers.Models;
using Microsoft.EntityFrameworkCore;

namespace BigCleopatraBurgers.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext dbContext;
        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            IEnumerable<Product> activeproducts = dbContext.Products.AsEnumerable();
            if (!activeproducts.Any())
            {
                await SeedData();
            }
            return await dbContext.Products
                .Where(p => p.Active.Equals(true))
                .ToListAsync();
        }

        private async Task SeedData()
        {
            var products = new List<Product>
            {
                new Product{ Id = 1, Name= "HamBurger", Active = true, Price = 5.55m},
                new Product{ Id = 2, Name= "CheeseBurger", Active = true, Price = 5.55m},
                new Product{ Id = 3, Name= "French Fries", Active = true, Price = 3.00m},
                new Product{ Id = 4, Name= "Pepperoni Pizza", Active = false, Price = 5.55m},
                new Product{ Id = 5, Name= "Salad", Active = true, Price = 4.55m},
                new Product{ Id = 6, Name= "Pepsi", Active = true, Price = 4.55m},
            };
            await dbContext.Products.AddRangeAsync(products);
            await dbContext.SaveChangesAsync();
        }
    }
}

