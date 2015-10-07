using System.Collections.Generic;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class ResourceProvidersPool : Entity, IResourceProvidersPool
    {
        public string Name { get; set; }

        public virtual ResourceCategory ResourceCategory { get; set; }

        IResourceCategory IResourceProvidersPool.ResourceCategory
        {
            get { return ResourceCategory; }
        }

        public virtual ICollection<ResourceProvider> Providers { get; set; }

        IEnumerable<IResourceProvider> IResourceProvidersPool.Providers
        {
            get { return Providers; }
        }
    }
}