using System.ComponentModel;
using Fortius.Domain;

namespace Bakery.Model
{
    /// <summary>
    /// Именованная сущность
    /// </summary>
    public class NamedEntity : Entity, INamedEntity<int>
    {
        [DisplayName("Наименование")]
        public string Name { get; set; }
    }
}
