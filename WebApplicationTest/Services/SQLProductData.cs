using System.Collections.Generic;
using System.Linq;
using WebApplicationTest.Interfaces;
using WebStore.DB;
using WebStore.Domain.Entities;

namespace WebApplicationTest.Services
{

    public class SQLProductData : IProductData
    {
        private readonly WebStoreContext context;

        public SQLProductData(WebStoreContext Context)
        {
            context = Context;
        }

        public IEnumerable<Brand> GetBrands()
        {
            var Brands = context.Brands.ToList();
            return Brands;
        }

        public IEnumerable<Category> GetCategories()
        {
            var Categories = context.Categories.ToList();
            return Categories;
        }

        public IEnumerable<Product> GetProducts(WebStore.Domain.Entities.ProductFilter filter)
        {
            var query = context.Products.AsQueryable();

            if (filter.BrandId.HasValue)
            {
                query = query.Where(c => c.BrandId.HasValue && c.BrandId.Value.Equals(filter.BrandId.Value));
            }
                
            if (filter.SectionId.HasValue)
            {
                query = query.Where(c => c.SectionId.Equals(filter.SectionId.Value));
            }

            return query.ToList();
        }
    }
}
