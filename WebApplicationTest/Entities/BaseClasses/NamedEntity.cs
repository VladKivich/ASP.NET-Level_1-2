using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Entities.Interfaces;

namespace WebApplicationTest.Entities.BaseClasses
{
    public class NamedEntity : INamedEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
