using Fortius.Domain;

namespace Bakery.Model
{
    public class Entity : IEntity<int>
    {
        public int Id { get; set; }
    }
}