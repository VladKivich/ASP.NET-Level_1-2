using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Entities.Interfaces;
using WebApplicationTest.Models.ViewModels;

namespace WebApplicationTest.ViewComponents
{
    public class BrandViewComponent:ViewComponent
    {
        private readonly IProductData Data;

        public BrandViewComponent(IProductData Data)
        {
            this.Data = Data;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Brands = GetBrands();
            return View(Brands);
        }

        private List<BrandViewModel> GetBrands()
        {
            var Brands = Data.GetBrands();

            var BrandsModelList = new List<BrandViewModel>();

            foreach (var Brand in Brands)
            {
                Random Rnd = new Random();
                BrandsModelList.Add(
                    new BrandViewModel(Brand.Name, Brand.Id, Brand.Order, Rnd.Next(5, 39))
                    );
            }

            BrandsModelList = (from b in BrandsModelList
                               orderby b.Order ascending
                               select b).ToList();

            return BrandsModelList;
        }
    }
}
