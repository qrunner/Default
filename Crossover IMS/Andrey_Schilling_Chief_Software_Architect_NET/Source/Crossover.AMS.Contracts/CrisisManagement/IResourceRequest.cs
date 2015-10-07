using System;
using System.Collections.Generic;

namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface IResourceRequest
    {
        IMission Mission { get; set; }

        IResourceCategory ResourceCategory { get; set; }

        decimal Amount { get; set; }

        DateTime Deadline { get; set; }

        string Description { get; set; }

        IEnumerable<IResourceResponse> Responses { get; }

        ResourceRequestState State { get; set; }
    }
}