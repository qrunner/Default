using System.Collections.Generic;

namespace Crossover.AMS.Contracts.CrisisManagement
{
    public interface ICollectionHostOf<T>
    {
        T AddItem();

        void RemoveItem(T item);

        IEnumerable<T> Items { get; }
    }
}