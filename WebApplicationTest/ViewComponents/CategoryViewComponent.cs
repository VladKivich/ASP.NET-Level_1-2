using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Entities.Interfaces;
using WebApplicationTest.Models.ViewModels;

namespace WebApplicationTest.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private readonly IProductData Data;

        public CategoryViewComponent(IProductData Data)
        {
            this.Data = Data;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Categories = GetCategories();
            return View(Categories);
        }

        private List<CategoryViewModel> GetCategories()
        {
            var Categories = Data.GetCategories();

            var ParentsCategories = Categories.Where(p => !p.ParentId.HasValue).ToArray();

            var CategoriesViewModel = new List<CategoryViewModel>();

            //Создаем "Родительские" CategoryViewModel 
            foreach (var PC in ParentsCategories)
            {
                CategoriesViewModel.Add(
                    new CategoryViewModel(PC.Name, PC.Id, PC.Order)
                    );
            }

            foreach (var ParentCategory in CategoriesViewModel)
            {
                //Получаем массив "Детей" для каждой категории "Родителей" по совпадению Id
                var ChildrenCategories = Categories.Where(c => c.ParentId == ParentCategory.Id).ToArray();

                //Каждого найденного "ребенка" добавляем в список ChildrensCategories его родителя
                foreach (var ChildCategory in ChildrenCategories)
                {
                    ParentCategory.ChildrensCategories.Add(
                        new CategoryViewModel(ChildCategory.Name, ChildCategory.Id, ChildCategory.Order)
                        {
                            //Задаем нужного родителя.
                            ParentCategory = ParentCategory
                        }
                        );
                }
                //Упорядочиваем список "детей" для каждого родителя
                ParentCategory.ChildrensCategories = (from c in ParentCategory.ChildrensCategories
                                                     orderby c.Order ascending
                                                     select c).ToList();
            }

            //Упорядочеваем список родителей
            CategoriesViewModel = (from p in CategoriesViewModel
                                   orderby p.Order ascending
                                   select p).ToList();

            //Возвращаем список 
            return CategoriesViewModel;
        }
    }
}
