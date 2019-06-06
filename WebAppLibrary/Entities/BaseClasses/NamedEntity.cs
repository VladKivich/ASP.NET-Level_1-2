using WebAppLibrary.Interfaces;

namespace WebAppLibrary.BaseClasses
{
    public class NamedEntity : INamedEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
