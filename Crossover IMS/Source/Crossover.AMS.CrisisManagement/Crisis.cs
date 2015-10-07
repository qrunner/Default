using System.Collections.Generic;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class Crisis : Entity, ICrisis
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }

        public virtual CrisisCategory Category { get; set; }

        ICrisisCategory ICrisis.Category
        {
            get { return Category; }
            set { Category = (CrisisCategory) value; }
        }

        IEnumerable<IIssue> ICrisis.Issues
        {
            get { return Issues; }
        }

        public IIssue AddIssue()
        {
            return AddItem(Issues);
        }

        public void RemoveIssue(IIssue issue)
        {
            RemoveItem(Issues, (Issue) issue);
            Issues.Remove((Issue) issue);
        }
    }
}