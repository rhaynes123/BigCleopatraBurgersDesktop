using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigCleopatraBurgers.Data;
using BigCleopatraBurgers.Models;
using Microsoft.EntityFrameworkCore;

namespace BigCleopatraBurgers.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        private readonly ApplicationDbContext dbContext;
        public OrderRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> CreateOrderAsync(Order order)
        {
            if (order is null || !order.OrderedProducts.Any())
            {
                return false;
            }
            dbContext.Orders.Add(order);
            await dbContext.OrderedProducts.AddRangeAsync(order.OrderedProducts);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Order> GetOrderByNumberAsync(Guid Number)
        {
            var orderedProducts = dbContext.OrderedProducts.Where(p => p.OrderNumber == Number).AsEnumerable();
            var order = await dbContext.Orders.SingleOrDefaultAsync(o => o.OrderNumber == Number);
            order.AddProducts(orderedProducts);
            return order;
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return await dbContext.Orders.ToListAsync();
        }

        public async Task<bool> UpdateOrderAsync(Order order)
        {
            if (order is null)
            {
                return false;
            }
            dbContext.Update(order);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOrderedProductAsync(OrderedProduct product)
        {
            if (product is null)
            {
                return false;
            }
            dbContext.Update(product);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}

