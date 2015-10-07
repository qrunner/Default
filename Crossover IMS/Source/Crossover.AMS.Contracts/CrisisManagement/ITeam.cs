using System.Collections.Generic;

namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface ITeam : IEntity
    {
        string Name { get; }

        IEnumerable<ITeamMember> Members { get; }
    }
}