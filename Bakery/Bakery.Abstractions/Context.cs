using System.Data.Entity;
using Fortius.Data.Entity;
using MySql.Data.Entity;

namespace Bakery.Model
{
    /// <summary>
    /// Точка входа для доступа к данным
    /// </summary>
    [DbConfigurationType(typeof (MySqlEFConfiguration))]
    public class Context : DbContext
    {
        /// <summary>
        /// Типы документов-оснований
        /// </summary>
        public DbSet<DocumentType> DocumentTypes { get; set; }

        /// <summary>
        /// Документы-основания
        /// </summary>
        public DbSet<Document> Documents { get; set; }

        /// <summary>
        /// Единицы ТМЦ
        /// </summary>
        public DbSet<Unit> Units { get; set; }

        /// <summary>
        /// Единицы измерения
        /// </summary>
        public DbSet<MeasureUnit> MeasureUnits { get; set; }

        /// <summary>
        /// Категории ТМЦ
        /// </summary>
        public DbSet<UnitCategory> UnitCategories { get; set; }

        /// <summary>
        /// Участки учета
        /// </summary>
        public DbSet<AccountingSite> Sites { get; set; }

        /// <summary>
        /// Контрагенты
        /// </summary>
        public DbSet<Contractor> Contractors { get; set; }

        /// <summary>
        /// Компании
        /// </summary>
        public DbSet<Company> Companies { get; set; }

        /// <summary>
        /// Журнал проводок
        /// </summary>
        public DbSet<Operation> OperationLog { get; set; }

        /// <summary>
        /// Рецепты приготовления
        /// </summary>
        public DbSet<Recipe> Recipies { get; set; }

        /// <summary>
        /// Заказы
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Пользователи системы
        /// </summary>
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Measure Units
            modelBuilder.Entity<MeasureUnit>().HasKey<int>(x => x.Id);
            modelBuilder.SetUniqueField<MeasureUnit>(x => x.Name, 128, "idx_MU_name", 1);
            modelBuilder.SetUniqueField<MeasureUnit>(x => x.ShortName, 8, "idx_MU_shortname", 2);

            // Unit Categories
            modelBuilder.Entity<UnitCategory>().HasKey<int>(x => x.Id);
            modelBuilder.Entity<UnitCategory>().HasMany<UnitCategory>(x => x.ChildItems);

            // Units
            modelBuilder.Entity<Unit>().HasKey<int>(x => x.Id);
            modelBuilder.SetUniqueField<Unit>(x => x.Name, 250, "idx_Unit_name", 1);

           // modelBuilder.Entity<RecipeUnitCount>().HasKey(t => new {t.UnitId, t.RecipeId});

            modelBuilder.Entity<Document>().Ignore(x => x.Name);

            //modelBuilder.Entity<DocumentType>().Ignore(x => x.SiteIds);
        }
    }
}