using System;

namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface ITeamMember : IEntity, IContactsProvider
    {
        Guid AccountSid { get; }

        string Email { get; }

        TeamMemberRole Role { get; }
    }
}