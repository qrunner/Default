using System.Collections.Generic;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class Team : Entity, ITeam
    {
        public string Name { get; set; }

        public virtual ICollection<TeamMember> Members { get; set; }

        IEnumerable<ITeamMember> ITeam.Members
        {
            get { return Members; }
        }
    }
}