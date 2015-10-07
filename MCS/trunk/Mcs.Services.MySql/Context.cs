using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity;
using Mcs.Model;
using MySql.Data.Entity;

namespace Mcs.Services.MySql
{
    /// <summary>
    /// Точка входа для доступа к данным
    /// </summary>
    [DbConfigurationType(typeof (MySqlEFConfiguration))]
    public class Context : DbContext, IChangeTracking
    {
        public Context() : this("Context")
        {

        }

        public Context(string contextName)
            : base(contextName)
        {
            Initialize();
        }

        private void Initialize()
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        /// <summary>
        /// Constructor to use on a DbConnection that is already opened
        /// </summary>
        /// <param name="existingConnection"></param>
        /// <param name="contextOwnsConnection"></param>
        public Context(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            Initialize();
        }

        /// <summary>
        /// Заведения
        /// </summary>
        public DbSet<Place> Places { get; set; }

        public DbSet<Desk> Desks { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<News> News { get; set; }
        
        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SetUniqueField<Place>(x => x.Name, 250, "idx_place_name", 1);
            modelBuilder.Entity<Place>().Property(x => x.Name).IsRequired();
            //modelBuilder.SetUniqueField<Desk>(x => x.Name, 250, "idx_desk_name", 1);

            /*modelBuilder.SetUniqueField<Producer>(x => x.Name, 250, "idx_producer_name", 1);
                modelBuilder.SetUniqueField<Supplier>(x => x.Name, 250, "idx_supplier_name", 1);
                modelBuilder.SetUniqueField<Customer>(x => x.Name, 250, "idx_customer_name", 1);
                // packing
                modelBuilder.Entity<Packing>().Property(x => x.Name).HasMaxLength(250).IsRequired();
                modelBuilder.Entity<Packing>().Property(x => x.ItemsCount).IsRequired();
                modelBuilder.Entity<Packing>().Property(x => x.Reusable).IsRequired();
                modelBuilder.Entity<Packing>().HasRequired(x => x.MeasureUnit);
                // products
                modelBuilder.Entity<Product>().HasRequired(x => x.MeasureUnit);
                modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(250).IsRequired();
                modelBuilder.Entity<Product>().Property(x => x.Price).IsRequired();
                // measure units
                modelBuilder.SetUniqueField<MeasureUnit>(x => x.FullName, 250, "idx_measureunit_name", 1);
                modelBuilder.Entity<MeasureUnit>().Property(x => x.ShortName).IsRequired();
                // invoices
                modelBuilder.Entity<Model.Invoice>().HasRequired(x => x.Customer);
                modelBuilder.Entity<Model.Invoice>().HasRequired(x => x.Supplier);
                modelBuilder.Entity<Model.Invoice>().HasRequired(x => x.Producer);
                modelBuilder.Entity<Model.Invoice>().Property(x => x.Date).IsRequired();
                // invoice items
                modelBuilder.Entity<InvoiceItem>().HasRequired(x => x.Product);
                modelBuilder.Entity<InvoiceItem>().Property(x => x.Count).IsRequired();*/
        }

        public void AcceptChanges()
        {
            SaveChanges();
        }

        public bool IsChanged
        {
            get { return ChangeTracker.HasChanges(); }
        }
    }
}
