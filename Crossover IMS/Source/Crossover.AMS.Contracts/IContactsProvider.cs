using System.Collections.Generic;

namespace Crossover.AMS.Contracts
{
    /// <summary>
    /// Have contacts
    /// </summary>
    public interface IContactsProvider
    {
        IEnumerable<IContact> Contacts { get; }
    }
}
