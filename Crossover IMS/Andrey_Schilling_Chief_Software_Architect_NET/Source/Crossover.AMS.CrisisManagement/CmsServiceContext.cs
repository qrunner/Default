using System.Collections.Generic;
using System.Data.Entity;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class CmsServiceContext : DbContext, ICmsService
    {
        public DbSet<Crisis> Crisises { get; set; }

        public DbSet<CrisisCategory> CrisisCategories { get; set; }

        public DbSet<Issue> Issues { get; set; }

        public DbSet<Mission> Missions { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<TeamMember> TeamMembers { get; set; }

        public DbSet<ResourceProvider> ResourceProviders { get; set; }

        public DbSet<ResourceProvidersPool> ResourceProvidersPools { get; set; }

        public DbSet<ResourceCategory> ResourceCategories { get; set; }

        public DbSet<ResourceRequest> ResourceRequests { get; set; }

        public DbSet<ResourceResponse> ResourceResponses { get; set; }

        public DbSet<TeamMemberContact> TeamMemberContacts { get; set; }

        public DbSet<ResourceProviderContact> ResourceProviderContacts { get; set; }

        ICrisis ICmsService.AddCrisis()
        {
            var crisis = new Crisis();
            Crisises.Add(crisis);
            return crisis;
        }

        IEnumerable<ICrisis> ICmsService.Crisises
        {
            get { return Crisises; }
        }

        IEnumerable<ICrisisCategory> ICmsService.CrisisCategories
        {
            get { return CrisisCategories; }
        }

        IEnumerable<IResourceCategory> ICmsService.ResourceCategories
        {
            get { return ResourceCategories; }
        }
    }
}