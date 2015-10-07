using System;
using System.Collections.Generic;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class ResourceRequest : Entity, IResourceRequest
    {
        public virtual Mission Mission { get; set; }

        public virtual ResourceCategory ResourceCategory { get; set; }

        public decimal Amount { get; set; }

        public DateTime Deadline { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ResourceResponse> Responses { get; set; }

        public ResourceRequestState State { get; set; }

        IMission IResourceRequest.Mission
        {
            get { return Mission; }
            set { Mission = (Mission) value; }
        }

        IResourceCategory IResourceRequest.ResourceCategory
        {
            get { return ResourceCategory; }
            set { ResourceCategory = (ResourceCategory) value; }
        }

        IEnumerable<IResourceResponse> IResourceRequest.Responses
        {
            get { return Responses; }
        }
    }
}