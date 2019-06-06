using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppLibrary.BaseClasses;
using WebAppLibrary.Interfaces;

namespace WebAppLibrary
{
    [Table("Categories")]
    public class Category : NamedEntity, IOrderedEntity
    {
        public int? ParentId { get; set; }
        public int Order { get; set; }

        public virtual List<Product> Products { get; set; }

        //Ссылка на родительскую категорию
        [ForeignKey("Parent_ID")]
        public virtual Category ParentCategory { get; set; }
        
    }
}
