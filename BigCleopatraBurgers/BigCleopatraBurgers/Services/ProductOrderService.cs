using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BigCleopatraBurgers.Models;
using BigCleopatraBurgers.Repositories;

namespace BigCleopatraBurgers.Services
{
	public class ProductOrderService
	{
		private readonly IOrderRepository OrderRepository;
		public ProductOrderService(IOrderRepository orderRepository)
		{
			OrderRepository = orderRepository;
		}

		public async Task<IEnumerable<Order>> GetOrdersAsync()
		{
			return await OrderRepository.GetOrdersAsync();
		}

		public async Task<bool> CreateOrderAsync(Order order)
		{
			return await OrderRepository.CreateOrderAsync(order);
		}

		public async Task<Order> GetOrderByNumberAsync(Guid Number)
		{
			return await OrderRepository.GetOrderByNumberAsync(Number);
		}

		public async Task<bool> UpdateOrderAsync(Order order)
		{
			return await OrderRepository.UpdateOrderAsync(order);
		}

		public async Task<bool> UpdateOrderedProductAsync(OrderedProduct orderedProduct)
		{
			return await OrderRepository.UpdateOrderedProductAsync(orderedProduct);
		}
	}
}

