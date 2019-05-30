using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Entities.Interfaces;

namespace WebApplicationTest.Entities.BaseClasses
{
    public class InMemoryProductData : IProductData
    {
        private readonly List<Brand> Brands;
        private readonly List<Category> Categories;

        public InMemoryProductData()
        {
            Categories = new List<Category>()
            {
                new Category("Sports Wear", 1, 0, null ),
                new Category("Nike", 2, 0, 1),
                new Category("Adidas", 3, 1, 1),
                new Category("Reebok", 4, 2,1),
                new Category("Childrens Wear", 5, 1, null),
                new Category("Acoola", 6, 0, 5),
                new Category("Babyglory", 7, 1, 5),
                new Category("Boom By Orby", 8, 2, 5),
                new Category("Womens Wear", 9, 2,null),
                new Category("Gucci", 10, 0, 9),
                new Category("Chanel", 11, 1, 9),
                new Category("Prada", 12, 2, 9),
                new Category("Mans Wear", 13, 3, null),
                new Category("Ralph Lauren", 14, 0, 13),
                new Category("Brooks Brothers", 15, 1, 13),
                new Category("Armani", 15, 2, 13)
            };

            Brands = new List<Brand>()
            {
                new Brand("Albiro", 0, 1),
                new Brand("Oddmolly", 1, 2),
                new Brand("Ronhill", 2, 3)
            };


        }

        public IEnumerable<Brand> GetBrands()
        {
            return Brands;
        }

        public IEnumerable<Category> GetCategories()
        {
            return Categories;
        }
    }
}
