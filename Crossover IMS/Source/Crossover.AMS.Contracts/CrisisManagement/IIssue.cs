using System.Collections.Generic;

namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface IIssue : IEntity
    {
        ICrisis Crisis { get; set; }

        IssueCategory Category { get; set; }

        IssueType Type { get; set; }

        string Description { get; set; }

        ICollection<string> Tags { get; set; }
    }
}