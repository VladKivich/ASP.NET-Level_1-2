using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Entities.Interfaces;

namespace WebApplicationTest.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductData Data;

        public CatalogController(IProductData Data)
        {
            this.Data = Data;
        }

        public IActionResult Products(int? BrandId, int? SectionId)
        {
            var AllProducts = Data.GetProducts(new Entities.ProductFilter(BrandId, SectionId));

            return View(AllProducts);
        }

        public IActionResult ProductDetails() => View();
    }
}