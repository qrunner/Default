using System.Collections.Generic;
using System.Collections.ObjectModel;
using Accounting;
using Production;

namespace Bakery.Model
{
    public class Recipe : Entity, IProductionInfo
    {
        public int ProductId { get; set; }

        public virtual Unit Product { get; set; }

        public string Prescription { get; set; }

        public virtual Collection<RecipeUnitCount> Components { get; set; }

        IEnumerable<IUnitCount> IProductionInfo.Components
        {
            get { return Components; }
        }
    }
}