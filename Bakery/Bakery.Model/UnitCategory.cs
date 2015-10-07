using System.Collections.Generic;
using Common.Structures;

namespace Bakery.Model.Implementation
{
    public class UnitCategory : NamedEntity, ITreeNode<UnitCategory>
    {
        public UnitCategory Parent { get; private set; }

        public IEnumerable<UnitCategory> ChildItems { get; private set; }
    }
}