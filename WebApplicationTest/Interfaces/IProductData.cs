using System.Collections.Generic;
using WebStore.Domain.Entities;

namespace WebApplicationTest.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Category> GetCategories();

        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter filter);
    }
}
