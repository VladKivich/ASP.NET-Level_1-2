using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Entities.BaseClasses;
using WebStore.Domain.Entities.Interfaces;

namespace WebStore.Domain.Entities
{
    [Table("Brand")]
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public virtual ICollection<Product> Products { get; set; }

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
