using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Entities.BaseClasses;
using WebStore.Domain.Entities.Interfaces;

namespace WebStore.Domain.Entities
{
    [Table("Products")]
    public class Product : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int SectionId { get; set; }

        [ForeignKey("SectionId")]
        public virtual Category Category { get; set; }

        public int? BrandId { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        public string ImgUrl { get; set; }

        public decimal Price { get; set; }
        
    }
}
