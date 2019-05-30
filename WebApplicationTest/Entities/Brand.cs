using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Entities.Interfaces;

namespace WebApplicationTest.Entities.BaseClasses
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public Brand(string Name, int Order, int Id)
        {
            this.Name = Name;
            this.Order = Order;
            this.Id = Id;
        }

        public Brand()
        {

        }
    }
}
