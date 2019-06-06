using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Interfaces;
using WebStore.Domain.Entities;

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
            var AllProducts = Data.GetProducts(new ProductFilter(BrandId, SectionId));

            return View(AllProducts);
        }

        public IActionResult ProductDetails() => View();
    }
}