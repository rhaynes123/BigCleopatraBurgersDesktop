using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BigCleopatraBurgers.Models.Enums;

namespace BigCleopatraBurgers.Models
{
	public record OrderedProduct
	{
		[Key]
		public int Id { get; init; }
		public string Name { get; init; }
		[Required]
		public Guid OrderNumber { get; init; }
		[Required, ForeignKey(nameof(ProductId))]
		public int ProductId { get; init; }
		[Required, Column(TypeName = "decimal(18, 6)")]
		public decimal Price { get; set; }
		[Required]
		public DateTime OrderDateTime { get; init; }
		[Required]
		public Status Status { get; private set; } = Status.Pending;
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

