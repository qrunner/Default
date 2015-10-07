using System.Data.Entity;

namespace Crossover.AMS.Communication.Models
{
    public class Context : DbContext
    {
        /// <summary>
        /// Accidents
        /// </summary>
        public DbSet<Accident> Accidents { get; set; }

        /// <summary>
        /// Accidents communication rooms
        /// </summary>
        public DbSet<Room> Rooms { get; set; }
    }
}