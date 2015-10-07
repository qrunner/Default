using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Crossover.AMS.Contracts.CrisisManagement;

namespace Crossover.AMS.CrisisManagement
{
    public class Entity : IEntity
    {
        [Key]
        public long Id { get; protected set; }

        protected T AddItem<T>(ICollection<T> collection) where T : new()
        {
            var item = new T();
            collection.Add(item);
            return item;
        }

        protected void RemoveItem<T>(ICollection<T> collection, T item)
        {
            collection.Remove(item);
        }
    }
}