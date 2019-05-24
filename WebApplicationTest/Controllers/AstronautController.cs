using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Interfaces;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class AstronautController : Controller
    {
        private readonly IAstronautsCollection _astronautsList;

        public AstronautController(IAstronautsCollection AstronautsList)
        {
            _astronautsList = AstronautsList;
        }

        public IActionResult AstronautsList()
        {
            return View(_astronautsList.GetAll());
        }
        
        public IActionResult AstronautDetails(int ID)
        {
            Astronauts A = _astronautsList.GetById(ID);
            return View(A);
        }
        
        public IActionResult Edit(int? ID)
        {
            Astronauts A;
            if (ID != null)
            {
                A = _astronautsList.GetById((int)ID);
                if (A is null)
                {
                    return NotFound(A);
                }
            }
            else
            {
                A = new Astronauts();
            }
            return View(A);
        }

        [HttpPost]
        public IActionResult Edit(Astronauts Astro)
        {
            if (!ModelState.IsValid)
            {
                return View(Astro);
            }

            if(Astro.ID > 0)
            {
                var Astronaut = _astronautsList.GetById(Astro.ID);

                if (Astronaut is null)
                {
                    return NotFound();
                }

                Astronaut.ChangeData(Astro);
            }
            else
            {
                _astronautsList.AddNewAstronaut(Astro);
            }
            _astronautsList.CommitChanges();

            return RedirectToAction("AstronautsList");
        }
        
        public IActionResult Delete(int ID)
        {
            Astronauts Astro = _astronautsList.GetById(ID);
            if (Astro != null)
            {
                _astronautsList.DeleteByID(ID);
            }
            return RedirectToAction("AstronautsList");
        }
    }
}