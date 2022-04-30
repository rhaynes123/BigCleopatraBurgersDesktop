using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BigCleopatraBurgers.Models.Enums;

namespace BigCleopatraBurgers.Models
{
	public class Order
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public Guid OrderNumber { get; set; } = Guid.NewGuid();
		[Required]
		public DateTime OrderDateTime { get; } = DateTime.UtcNow;
		[Required]
		public Status Status { get; private set; } = Status.Pending;
		[Required, Column(TypeName = "decimal(18, 6)")]
		public decimal Total { get; private set; } = 0;
		[NotMapped]
		public IList<OrderedProduct> OrderedProducts = new List<OrderedProduct>();

		public void AddProduct(Product product)
		{
			OrderedProducts.Add(new OrderedProduct
			{
				OrderNumber = OrderNumber,
				ProductId = product.Id,
				Price = product.Price,
				Name = product.Name,
				OrderDateTime = OrderDateTime
			});
		}

		public void RemoveProduct(Product product)
		{
			if (OrderedProducts.Any(o => o.ProductId == product.Id))
			{
				OrderedProduct productToRemove = OrderedProducts.FirstOrDefault(o => o.ProductId == product.Id);
				OrderedProducts.Remove(productToRemove);
			}
		}

		public void AddProducts(IEnumerable<OrderedProduct> products)
		{
			if (products is null || !products.Any())
			{
				throw new InvalidOperationException("Prodcuts Cannot Be Null Or Empty");
			}
			OrderedProducts = products.ToList();

		}

		public void SetTotal()
		{
			Total = CalculateTotal();

		}

		public decimal CalculateTotal()
		{
			return OrderedProducts is null
				|| !OrderedProducts.Any() ? 0 : OrderedProducts.Where(o => !o.Status.Equals(Status.Cancelled)).Select(p => p.Price).Sum();
		}

		public void SetStatus(Status status)
		{
			Status = status switch
			{
				Status.Pending => throw new InvalidOperationException(message: "Pending Is Default Status And Doesn't Need To Be Set"),
				_ => status,
			};
		}


	}
}

