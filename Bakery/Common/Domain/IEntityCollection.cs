using System.Collections.Generic;

namespace Fortius.Domain
{
    /// <summary>
    /// Представляет коллекцию сущностей
    /// </summary>
    /// <typeparam name="T">Тип сущности в коллекции</typeparam>
    public interface IEntityCollection<T> : IEnumerable<T>
    {
        T Add();

        T this[int index] { get; set; }

        void Remove(T item);

        int Count { get; }
    }
}