using System.Collections.Generic;
using WebApplicationTest.Entities.BaseClasses;

namespace WebApplicationTest.Entities.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Category> GetCategories();

        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter filter);
    }
}
