using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class AstronautController : Controller
    {
        public List<Astronauts> _astronautsList = new List<Astronauts>
        {
            new Astronauts(0, "VOSS Janice Elaine", "NASA-13", new DateTime(1990,1,1),"Mission Specialist", Status.Former, 5, Gender.female),
            new Astronauts(1, "VOSS James Shelton", "NASA-13", new DateTime(1987,1,1),"Mission Specialist", Status.Former, 5, Gender.male),
            new Astronauts(2, "VIRTS, Jr.Terry Wayne", "NASA-18", new DateTime(2000,1,1),"Pilot", Status.Former, 2, Gender.male),
            new Astronauts(3, "VEACH Charles Lacy", "MSE-1", new DateTime(1979,1,1),"Mission Specialist", Status.Former, 2, Gender.male),
            new Astronauts(4, "van HOFTEN James Dougal Adrianus", "NASA-8", new DateTime(1978,1,1),"Mission Specialist 	", Status.Former, 2, Gender.male),
            new Astronauts(5, "VANGEN Scott Duane", "ASTRO-2", new DateTime(1993,1,1),"Payload Specialist", Status.Former, 0, Gender.male),
        };

        public IActionResult AstronautsList()
        {
            return View(_astronautsList);
        }

        public IActionResult AstronautDetails(int ID)
        {
            Astronauts A = _astronautsList.FirstOrDefault(e => e.ID == ID);
            return View(A);
        }
    }
}