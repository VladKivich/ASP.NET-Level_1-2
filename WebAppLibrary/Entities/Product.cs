using System;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppLibrary.BaseClasses;
using WebAppLibrary.Interfaces;

namespace WebAppLibrary
{
    [Table("Products")]
    public class Product : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int? SectionId { get; set; }

        public int? BrandId { get; set; }

        public string ImgUrl { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("Category_ID")]
        public virtual Category Category { get; set; }

        [ForeignKey("Brand_ID")]
        public virtual Brand Brand { get; set; }
    }
}
