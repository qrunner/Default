using Common.Domain;

namespace Bakery.Model.Implementation
{
    public class Entity : IEntity<int>
    {
        public int Id { get; set; }
    }
}