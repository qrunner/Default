using System.Data.Entity;
using Invoice.Model;
using MySql.Data.Entity;
using System.Data.Common;
using System.ComponentModel;
using Sirius.EntityFramework;

namespace Invoice.ServiceLayer.MySql
{
    /// <summary>
    /// Точка входа для доступа к данным
    /// </summary>
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Context : DbContext, IChangeTracking
    {
        public Context(string contextName)
            : base(contextName)
        {
            
        }

        /// <summary>
        /// Constructor to use on a DbConnection that is already opened
        /// </summary>
        /// <param name="existingConnection"></param>
        /// <param name="contextOwnsConnection"></param>
        public Context(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }

        /// <summary>
        /// Список накладных
        /// </summary>
        public DbSet<Model.Invoice> Invoices { get; set; }

        /// <summary>
        /// Список позиций в накладных
        /// </summary>
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        /// <summary>
        /// Поставщики
        /// </summary>
        public DbSet<Producer> Producers { get; set; }

        /// <summary>
        /// Продавцы
        /// </summary>
        public DbSet<Supplier> Suppliers { get; set; }

        /// <summary>
        /// Покупатели
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// Товары / продукция
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Единицы измерения
        /// </summary>
        public DbSet<MeasureUnit> MeasureUnits { get; set; }

        /// <summary>
        /// Упаковки
        /// </summary>
        public DbSet<Packing> Packings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SetUniqueField<Producer>(x => x.Name, 250, "idx_producer_name", 1);
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
            modelBuilder.Entity<InvoiceItem>().Property(x => x.Count).IsRequired();            
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