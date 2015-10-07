using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mcs.Services.Storage
{
    /// <summary>
    /// Фабрика сторожей
    /// </summary>
    public interface IStorageFactory
    {
        /// <summary>
        /// Получает сторожа для определенного типа
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <returns>Сторож объектов T</returns>
        IStorage<T> GetStorage<T>();
    }
}