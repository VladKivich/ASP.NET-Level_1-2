using System;
using WebApplicationTest.Entities.BaseClasses;
using WebApplicationTest.Entities.Interfaces;

namespace WebApplicationTest.Entities
{
    public class Product : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int? SectionId { get; set; }

        public int? BrandId { get; set; }

        public string ImgUrl { get; set; }

        public decimal Price { get; set; }

        public Product(int Id, string Name, decimal Price, string ImgUrl, int Order, int SectionId, int BrandId, bool ShopImg)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.ImgUrl = ShopImg ? "/images/shop/" + ImgUrl : "/images/home/" + ImgUrl;
            this.Order = Order;
            this.SectionId = SectionId;
            this.BrandId = BrandId;
        }
    }
}
