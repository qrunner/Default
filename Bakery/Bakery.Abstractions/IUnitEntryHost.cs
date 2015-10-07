using System.Collections.Generic;

namespace Bakery.Model
{
    public interface IUnitEntryHost
    {
        IList<UnitEntry> Items { get; }
    }
}
