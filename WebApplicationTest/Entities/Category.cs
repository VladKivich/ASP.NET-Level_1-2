using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Entities.Interfaces;

namespace WebApplicationTest.Entities.BaseClasses
{
    public class Category : NamedEntity, IOrderedEntity
    {

        public int? ParentId { get; set; }
        public int Order { get; set; }

        public Category(string Name, int Id, int Order, int? ParentId)
        {
            this.Name = Name;
            this.Order = Order;
            this.Id = Id;
            this.ParentId = ParentId;
        }

        public Category()
        {

        }
        
    }
}
