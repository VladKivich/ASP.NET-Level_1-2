using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Entities.Interfaces;

namespace WebApplicationTest.Controllers
{
    public class HomePageController : Controller
    {
        private readonly IProductData Data;

        public HomePageController(IProductData Data)
        {
            this.Data = Data;
        }

        public IActionResult Index()
        {
            return View(Data.GetProducts(new Entities.ProductFilter(null, null)));
        }
        
        public IActionResult Login() => View();

        public IActionResult ContactUs() => View();

        public IActionResult Checkout() => View();

        public IActionResult Cart() => View();

        public IActionResult BlogSingle() => View();

        public IActionResult Blog() => View();

        public IActionResult Error404() => View();
    }
}