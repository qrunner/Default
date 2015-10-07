using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Common.Domain;

namespace Bakery.Model.Implementation
{
    internal class EntityCollection<T> : IEntityCollection<T> where T : class
    {
        private readonly DbSet<T> _dbSet;

        public EntityCollection(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _dbSet.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T Add()
        {
            return _dbSet.Create();
        }

        public T this[int index]
        {
            get { return _dbSet.Local[index]; }
            set { _dbSet.Local[index] = value; }
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public int Count
        {
            get { return _dbSet.Count(); }
        }
    }
}