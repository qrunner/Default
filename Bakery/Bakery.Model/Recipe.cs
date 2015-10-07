using System.Collections.Generic;
using Accounting;
using Production;

namespace Bakery.Model.Implementation
{
    public class Recipe : Entity, IProductionInfo
    {
        public int ProductId { get; set; }

        public string Prescription { get; set; }

        public IEnumerable<IUnitCount> Components { get; set; }
    }
}