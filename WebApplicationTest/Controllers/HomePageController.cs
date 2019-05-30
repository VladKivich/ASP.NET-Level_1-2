using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTest.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Login() => View();

        public IActionResult ContactUs() => View();

        public IActionResult Checkout() => View();

        public IActionResult Cart() => View();

        public IActionResult BlogSingle() => View();

        public IActionResult Blog() => View();

        public IActionResult Error404() => View();

        public IActionResult Products() => View();

        public IActionResult ProductDetails() => View();
    }
}