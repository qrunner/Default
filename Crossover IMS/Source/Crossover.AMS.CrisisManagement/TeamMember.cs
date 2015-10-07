using System;
using System.Collections.Generic;
using Crossover.AMS.Contracts;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class TeamMember : Entity, ITeamMember
    {
        public Guid AccountSid { get; set; }

        public string Email { get; set; }

        public TeamMemberRole Role { get; set; }
        
        public virtual ICollection<TeamMemberContact> Contacts { get; set; }

        IEnumerable<IContact> IContactsProvider.Contacts
        {
            get { return Contacts; }
        }
    }
}