using System.Collections.Generic;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class Issue : Entity, IIssue
    {
        ICrisis IIssue.Crisis
        {
            get { return Crisis; }
            set { Crisis = (Crisis) value; }
        }

        public virtual Crisis Crisis { get; set; }
        public IssueCategory Category { get; set; }
        public IssueType Type { get; set; }
        public string Description { get; set; }
        public virtual ICollection<string> Tags { get; set; }
    }
}