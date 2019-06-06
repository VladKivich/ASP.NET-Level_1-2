using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Entities.Interfaces;

namespace WebApplicationTest.Models.ViewModels
{
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Order { get; set; }
        public string ImgUrl { get; set; }
        public decimal Price { get; set; }

        public int? SectionId { get; set; }

        public int? BrandId { get; set; }

        public ProductViewModel(int Id,string Name, int Order, string ImgUrl, decimal Price, int? SectionId = null, int? BrandId = null)
        {

        }
    }
}
