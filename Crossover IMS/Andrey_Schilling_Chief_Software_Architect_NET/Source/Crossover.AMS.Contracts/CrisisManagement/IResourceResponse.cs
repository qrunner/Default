using System;

namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface IResourceResponse : IEntity
    {
        IResourceRequest Request { get; }

        decimal Amount { get; }

        DateTime ProvisionExpected { get; }

        bool Accepted { get; set; }
    }
}