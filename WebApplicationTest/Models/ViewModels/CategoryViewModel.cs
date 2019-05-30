using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Entities.Interfaces;

namespace WebApplicationTest.Models.ViewModels
{
    public class CategoryViewModel : INamedEntity, IOrderedEntity
    {
        public CategoryViewModel(string Name, int Id, int Order)
        {
            ChildrensCategories = new List<CategoryViewModel>();
            this.Name = Name;
            this.Id = Id;
            this.Order = Order;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int Order { get; set; }

        public List<CategoryViewModel> ChildrensCategories { get; set; }

        public CategoryViewModel ParentCategory { get; set; }
    }
}
