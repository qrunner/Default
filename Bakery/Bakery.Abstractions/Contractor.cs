using System.Collections.Generic;

namespace Bakery.Model
{
    /// <summary>
    /// Контрагент
    /// </summary>
    public class Contractor : NamedEntity
    {
        public bool IsClient { get; set; }

        public bool IsSupplier { get; set; }

        public ICollection<Document> Documents { get; protected set; }
    }
}
