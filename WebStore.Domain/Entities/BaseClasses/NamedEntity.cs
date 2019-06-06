using WebStore.Domain.Entities.Interfaces;

namespace WebStore.Domain.Entities.BaseClasses
{
    public class NamedEntity : BaseEntity, INamedEntity
    {
        public string Name { get; set; }
    }
}
