using System.Data.Entity;
using Bakery.Model.Implementation;

namespace Bakery.Repository
{
    internal class Context : DbContext
    {
        public DbSet<Unit> Units { get; set; }


        public DbSet<MeasureUnit> MeasureUnits { get; set; }


        public DbSet<UnitCategory> UnitCategories { get; set; }

        /// <summary>
        /// Единицы, принятые от поставщика (купленные)
        /// </summary>
        public DbSet<UnitEntry> Bought { get; set; }

        /// <summary>
        /// Единицы на складе
        /// </summary>
        public DbSet<UnitEntry> Warehouse { get; set; }

        /// <summary>
        /// Единицы в пекарне
        /// </summary>
        public DbSet<UnitEntry> Bakery { get; set; }

        /// <summary>
        /// Единицы, выданные клиентам (проданные)
        /// </summary>
        public DbSet<UnitEntry> Sold { get; set; }

        /// <summary>
        /// Списанные единицы
        /// </summary>
        public DbSet<UnitEntry> Decomissed { get; set; }

        /// <summary>
        /// Документы
        /// </summary>
        public DbSet<Document> Documents { get; set; }

        public DbSet<TEntity> Table<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }
    }
}