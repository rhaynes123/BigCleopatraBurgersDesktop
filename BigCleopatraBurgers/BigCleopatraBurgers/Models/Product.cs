using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigCleopatraBurgers.Models
{
	public record Product
	{
		[Key]
		public int Id { get; init; }
		public string Name { get; init; }
		[Required, Column(TypeName = "decimal(18, 6)")]
		public decimal Price { get; init; }
		[Required]
		public bool Active { get; init; } = true;
	}
}

