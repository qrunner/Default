using System.Collections.Generic;

namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface ICrisis : IEntity
    {
        string Name { get; set; }

        string Description { get; set; }
 
        IEnumerable<IIssue> Issues { get; }

        IIssue AddIssue();

        void RemoveIssue(IIssue issue);

        ICrisisCategory Category { get; set; }
    }
}