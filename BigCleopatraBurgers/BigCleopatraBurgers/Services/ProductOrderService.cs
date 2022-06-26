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
		private readonly IQueueProducerService QueueProducerService;
		public ProductOrderService(IOrderRepository orderRepository
			, IQueueProducerService queueProducerService)
		{
			OrderRepository = orderRepository;
			QueueProducerService = queueProducerService;
		}

		public async Task<IEnumerable<Order>> GetOrdersAsync()
		{
			return await OrderRepository.GetOrdersAsync();
		}
		//public async Task<(bool, Order)> GetQueuedOrderAsync()
		//{
		//	return await QueueConsumerService.TryConsumeAsync<Order>("NewOrders"); ;
		//}

		public async Task<bool> CreateOrderAsync(Order order)
		{
			var result = await OrderRepository.CreateOrderAsync(order);
			if(!result)
            {
				return false;
            }
			return await QueueProducerService.TryPublishAsync(topicname: "NewOrders", data: order);
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

