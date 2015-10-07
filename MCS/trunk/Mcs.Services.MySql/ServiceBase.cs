using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Mcs.Model;

namespace Mcs.Services.MySql
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : class, IEntity
    {
        protected virtual DbQuery<T> Table(DbContext context)
        {
            return context.Set<T>();
        }       

        public T Get(int id)
        {
            using (var ctx = new Context())
            {
                return Table(ctx).Single(x => x.Id == id);
            }
        }

        public IEnumerable<T> Get(Func<T, bool> filter)
        {
            using (var ctx = new Context())
            {
                return Table(ctx).Where(filter).ToArray();
            }
        }

        public IEnumerable<T> Get(Func<T, bool> filter, int skip, int take)
        {
            using (var ctx = new Context())
            {
                return Table(ctx).Where(filter).Skip(skip).Take(take).ToArray();
            }
        }

        public T Save(T item)
        {
            using (var ctx = new Context())
            {
                BeforeSaveInternal(ctx, item);

                ctx.Entry(item).State = item.Id > 0 ? EntityState.Modified : EntityState.Added;

                ctx.SaveChanges();

                AfterSaveInternal(ctx, item);

                return item;
            }
        }

        protected virtual void AfterSaveInternal(Context ctx, T item)
        {
            
        }

        protected virtual void BeforeSaveInternal(Context ctx, T item)
        {

        }

        public void Delete(int id)
        {
            using (var ctx = new Context())
            {
                ctx.Set<T>().Remove(Table(ctx).Single(x => x.Id == id));

                ctx.SaveChanges();
            }
        }
    }
}