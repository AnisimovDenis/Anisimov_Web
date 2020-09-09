using Anisimov.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anisimov.Infrastructure.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Category> GetCategories();

        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter filter);
    }
}
