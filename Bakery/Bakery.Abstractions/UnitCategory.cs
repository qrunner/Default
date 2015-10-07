using System.Collections.Generic;
using Fortius.Structures;

namespace Bakery.Model
{
    public class UnitCategory : NamedEntity, ITreeNode<UnitCategory>
    {
        public virtual UnitCategory Parent { get; set; }

        public virtual ICollection<UnitCategory> ChildItems { get; set; }
    }
}