using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BigCleopatraBurgers.Models;

namespace BigCleopatraBurgers.Repositories
{
	public interface IOrderRepository
	{
		Task<IEnumerable<Order>> GetOrdersAsync();
		Task<bool> CreateOrderAsync(Order order);
		Task<Order> GetOrderByNumberAsync(Guid Number);
		Task<bool> UpdateOrderAsync(Order order);
		Task<bool> UpdateOrderedProductAsync(OrderedProduct product);
	}
}

