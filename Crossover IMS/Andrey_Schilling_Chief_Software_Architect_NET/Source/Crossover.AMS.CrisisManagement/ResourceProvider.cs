using System.Collections.Generic;
using Crossover.AMS.Contracts;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class ResourceProvider : Entity, IResourceProvider
    {
        public ResourceCategory ResourceCategory { get; set; }

        IResourceCategory IResourceProvider.ResourceCategory
        {
            get { return ResourceCategory; }
        }

        public ResourceProviderCategory ProviderCategory { get; set; }

        public string Name { get; set; }

        public bool Available { get; set; }

        public virtual ICollection<ResourceProviderContact> Contacts { get; set; }

        IEnumerable<IContact> IContactsProvider.Contacts
        {
            get { return Contacts; }
        }
    }
}