using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Entities.BaseClasses;
using WebStore.Domain.Entities.Interfaces;

namespace WebStore.Domain.Entities
{
    [Table("Categories")]
    public class Category : NamedEntity, IOrderedEntity
    {

        public int? ParentId { get; set; }
        public int Order { get; set; }

        [ForeignKey("ParentId")]
        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<Product> Products { get; set; }

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
