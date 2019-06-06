using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppLibrary.BaseClasses;
using WebAppLibrary.Interfaces;

namespace WebAppLibrary
{
    [Table("Brands")]
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
