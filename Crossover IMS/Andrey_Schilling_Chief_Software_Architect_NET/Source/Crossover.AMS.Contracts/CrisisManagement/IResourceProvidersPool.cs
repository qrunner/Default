using System.Collections.Generic;

namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface IResourceProvidersPool
    {
        string Name { get; }

        IResourceCategory ResourceCategory { get; }

        IEnumerable<IResourceProvider> Providers { get; }
    }
}