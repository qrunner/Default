using System;
using System.Collections.Generic;

namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface ICmsService : IDisposable
    {
        ICrisis AddCrisis();
        
        IEnumerable<ICrisis> Crisises { get; }

        IEnumerable<ICrisisCategory> CrisisCategories { get; }

        IEnumerable<IResourceCategory> ResourceCategories { get; }

        int SaveChanges();
    }
}