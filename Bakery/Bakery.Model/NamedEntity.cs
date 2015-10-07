using Common.Domain;

namespace Bakery.Model.Implementation
{
    public class NamedEntity : Entity, INamedEntity<int>
    {
        public string Name { get; set; }
    }
}
