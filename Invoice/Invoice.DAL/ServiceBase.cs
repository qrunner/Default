using Invoice.Model;
using MySql.Data.Entity;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;

namespace Invoice.ServiceLayer.MySql
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ServiceBase<T> : DbContext, IService<T> where T : Entity
    {    
        public ServiceBase(string contextName)
            : base(contextName)
        {

        }

        /// <summary>
        /// Constructor to use on a DbConnection that is already opened
        /// </summary>
        /// <param name="existingConnection"></param>
        /// <param name="contextOwnsConnection"></param>
        public ServiceBase(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }

        public T GetById(int id)
        {
            return Table.Single(x => x.Id == id);
        }

        public IQueryable<T> Items { get { return Table; } }

        public DbSet<T> Table { get; set; }

        public void Save(T item)
        {
            if (item.Id <= 0)
                Table.Add(item);

            SaveChanges();
        }

        public void Delete(T item)
        {
            Table.Remove(item);
            SaveChanges();
        }

        public void AcceptChanges()
        {
            SaveChanges();
        }

        public bool IsChanged
        {
            get { return this.ChangeTracker.HasChanges(); }
        }
    }
}