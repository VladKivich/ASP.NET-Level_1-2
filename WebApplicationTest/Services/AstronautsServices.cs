using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Interfaces;
using WebApplicationTest.Models;

namespace WebApplicationTest.Services
{
    public class AstronautsServices : IAstronautsCollection
    {
        public List<Astronauts> _astronautsList = new List<Astronauts>
            {
                new Astronauts(1, "VOSS Janice Elaine", "NASA-13", 1990,"Mission Specialist", Status.Former, 5, Gender.female),
                new Astronauts(2, "VOSS James Shelton", "NASA-13", 1987,"Mission Specialist", Status.Former, 5, Gender.male),
                new Astronauts(3, "VIRTS, Jr.Terry Wayne", "NASA-18", 2000, "Pilot", Status.Former, 2, Gender.male),
                new Astronauts(4, "VEACH Charles Lacy", "MSE-1", 1979,"Mission Specialist", Status.Former, 2, Gender.male),
                new Astronauts(5, "van HOFTEN James Dougal Adrianus", "NASA-8", 1978, "Mission Specialist 	", Status.Former, 2, Gender.male),
                new Astronauts(6, "VANGEN Scott Duane", "ASTRO-2", 1993, "Payload Specialist", Status.Former, 0, Gender.male),
            };


        public void AddNewAstronaut(Astronauts NewAstronaut)
        {
            if (!_astronautsList.Contains(NewAstronaut))
            {
                _astronautsList.Add(NewAstronaut);
            }
        }

        public void CommitChanges()
        {

        }

        public bool DeleteByID(int ID)
        {
            var result = _astronautsList.FirstOrDefault(astro => astro.ID == ID);
            _astronautsList.Remove(result);
            return result is null ? false : true;
        }

        public IEnumerable<Astronauts> GetAll()
        {
            return _astronautsList;
        }

        public Astronauts GetById(int ID)
        {
            var Result = _astronautsList.FirstOrDefault(astro => astro.ID == ID);

            return Result is null ? new Astronauts((byte)(_astronautsList.Max(astro => astro.ID) + 1)) : Result;
        }
    }
}
