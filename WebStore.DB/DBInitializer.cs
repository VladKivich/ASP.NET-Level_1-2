using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities;

namespace WebStore.DB
{
    public static class DBInitializer
    {
        public static void Initialize(WebStoreContext Context)
        {
            //Убедимся что БД создана
            Context.Database.EnsureCreated();

            if (Context.Products.Any())
            {

            }

            #region Data

            var Categories = new List<Category>()
            {
                new Category("Sports Wear", 1, 0, null),
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

            var Brands = new List<Brand>()
            {
                new Brand("Albiro", 0, 1),
                new Brand("Oddmolly", 1, 2),
                new Brand("Ronhill", 2, 3)
            };

            var Products = new List<Product>()
            {
                new Product(1, "Easy Polo Black Edition", 1000, "product12.jpg", 0, 1, 1, true),
                new Product(1, "Easy Polo Black Edition", 2000, "product11.jpg", 0, 1, 1, true),
                new Product(1, "Easy Polo Black Edition", 3000, "product10.jpg", 0, 1, 1, true),
                new Product(1, "Easy Polo Black Edition", 4000, "product9.jpg", 0, 5, 1, true),
                new Product(1, "Easy Polo Black Edition", 5000, "product8.jpg", 0, 5, 2, true),

                new Product(1, "Easy Polo Black Edition", 6000, "product7.jpg", 0, 5, 2, true),
                new Product(1, "Easy Polo Black Edition", 7000, "product1.jpg", 0, 9, 2, false),
                new Product(1, "Easy Polo Black Edition", 8000, "product2.jpg", 0, 9, 2, false),
                new Product(1, "Easy Polo Black Edition", 9000, "product3.jpg", 0, 9, 3, false),
                new Product(1, "Easy Polo Black Edition", 9500, "product4.jpg", 0, 13, 3, false),

                new Product(1, "Easy Polo Black Edition", 9600, "product5.jpg", 0, 13, 3, false),
                new Product(1, "Easy Polo Black Edition", 9700, "product6.jpg", 0, 13, 3, false),
            };

            #endregion
        }
    }
}
