using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BigCleopatraBurgers.Models;

namespace BigCleopatraBurgers.Repositories
{
	public interface IProductRepository
	{
		Task<IEnumerable<Product>> GetProductsAsync();
	}
}

