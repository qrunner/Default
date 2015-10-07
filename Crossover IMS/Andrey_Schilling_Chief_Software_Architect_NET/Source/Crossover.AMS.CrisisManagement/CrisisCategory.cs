using System.Collections.Generic;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class CrisisCategory : Entity, ICrisisCategory
    {
        public string Name { get; set; }

        public virtual CrisisCategory Parent { get; set; }

        public virtual ICollection<ICrisisCategory> ChildCategories { get; set; }

        ICrisisCategory ICrisisCategory.Parent
        {
            get { return Parent; }
        }

        IEnumerable<ICrisisCategory> ICrisisCategory.ChildCategories
        {
            get { return ChildCategories; }
        }
    }
}