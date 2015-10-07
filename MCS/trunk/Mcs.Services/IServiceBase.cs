using System;
using System.Collections.Generic;
using Mcs.Model;

namespace Mcs.Services
{
    /// <summary>
    /// Предоставляем методы базовой службы
    /// </summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    public interface IServiceBase<T> where T : IEntity
    {
        /// <summary>
        /// Получает сущность по её идентификатору
        /// </summary>
        /// <param name="id">Идентификатор сущности</param>
        /// <returns>Сущность</returns>
        T Get(int id);

        /// <summary>
        /// Получает сущности заданного типа
        /// </summary>
        /// <returns>Набор элементов</returns>
        IEnumerable<T> Get(Func<T, bool> filter);

        /// <summary>
        /// Получает список заданного количества сущностей начиная с указанной
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="skip">Пропустить элементов</param>
        /// <param name="take">Получить элементов</param>
        /// <returns>Набор элементов</returns>
        IEnumerable<T> Get(Func<T, bool> filter, int skip, int take);

        /// <summary>
        /// Сохраняет сущность. Если сущности не существовало, она добавляется
        /// </summary>        
        /// <param name="item">Сущность</param>
        T Save(T item);

        /// <summary>
        /// Удаляет сущность
        /// </summary>
        /// <param name="id">Идентификатор</param>
        void Delete(int id);
    }
}