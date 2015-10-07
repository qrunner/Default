using System.Collections.Generic;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class Mission : Entity, IMission
    {
        public virtual Issue Issue { get; set; }

        IIssue IMission.Issue
        {
            get { return Issue; }
            set { Issue = (Issue) value; }
        }

        public string Title { get; set; }

        public string Description { get; set; }

        IEnumerable<IResourceRequest> IMission.ResourceRequests
        {
            get { return ResourceRequests; }
        }

        public IResourceRequest AddResourceRequest()
        {
            return AddItem(ResourceRequests);
        }

        public void RemoveResourceRequest(IResourceRequest resourceRequest)
        {
            RemoveItem(ResourceRequests, (ResourceRequest) resourceRequest);
        }

        public virtual ICollection<ResourceRequest> ResourceRequests { get; set; }

        ITeamMember IMission.Assignee
        {
            get { return Assignee; }
            set { Assignee = (TeamMember) value; }
        }

        public virtual TeamMember Assignee { get; set; }
    }
}