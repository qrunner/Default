using System.Collections.Generic;

namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface IMission : IEntity
    {
        IIssue Issue { get; set; }

        string Title { get; set; }

        string Description { get; set; }

        IEnumerable<IResourceRequest> ResourceRequests { get; }

        IResourceRequest AddResourceRequest();

        void RemoveResourceRequest(IResourceRequest resourceRequest);

        ITeamMember Assignee { get; set; }
    }
}