using System.Collections.Generic;

namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface ICrisisCategory : IEntity
    {
        string Name { get; }

        ICrisisCategory Parent { get; }

        IEnumerable<ICrisisCategory> ChildCategories { get; }
    }
}