using System.Data.Entity;

namespace Crossover.AMS.Communication.Model
{
    internal class DataContext : DbContext
    {
        public DataContext()
        {
            //Database.Delete();
        }
        public DbSet<Conference> Conferences { get; set; }

        public DbSet<PrivateMessage> PrivateMessages { get; set; }
    }
}