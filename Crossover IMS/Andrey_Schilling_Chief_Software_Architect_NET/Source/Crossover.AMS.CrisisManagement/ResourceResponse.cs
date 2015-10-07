using System;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class ResourceResponse : Entity, IResourceResponse
    {
        IResourceRequest IResourceResponse.Request
        {
            get { return Request; }
        }

        public virtual ResourceRequest Request { get; set; }

        public decimal Amount { get; set; }

        public DateTime ProvisionExpected { get; set; }

        public bool Accepted { get; set; }
    }
}