using System.Collections.Generic;
using WebApplicationTest.Entities.BaseClasses;

namespace WebApplicationTest.Entities.Interfaces
{
    interface IProductData
    {
        IEnumerable<Category> GetCategories();

        IEnumerable<Brand> GetBrands();
    }
}
