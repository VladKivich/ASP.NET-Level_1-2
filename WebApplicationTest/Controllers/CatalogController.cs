using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTest.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Products() => View();

        public IActionResult ProductDetails() => View();
    }
}