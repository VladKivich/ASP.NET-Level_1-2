using WebStore.Domain.Entities.Interfaces;

namespace WebApplicationTest.Models.ViewModels
{
    public class BrandViewModel : INamedEntity, IOrderedEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Order { get; set; }

        public int Count { get; set; }

        public BrandViewModel(string Name, int Id, int Order, int Count)
        {
            this.Name = Name;
            this.Id = Id;
            this.Order = Order;
            this.Count = Count;
        }
    }
}
