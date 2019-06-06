using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Domain.Entities
{
    public class ProductFilter
    {
        public int? SectionId { get; set; }

        public int? BrandId { get; set; }

        public ProductFilter(int? BrandId, int? SectionId)
        {
            this.BrandId = BrandId;
            this.SectionId = SectionId;
        }
    }
}
