using System;
using System.ComponentModel;
using System.Linq;

namespace Invoice.Model
{
    /// <summary>
    /// Служба работы с сущностями
    /// </summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    public interface IService<T> : IDisposable, IChangeTracking where T : Entity
    {
        /// <summary>
        /// Получает сущность по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Возвращает интерфейс доступа ко всем сущностям
        /// </summary>        
        IQueryable<T> Items { get; }
        
        /// <summary>
        /// Сохраняет новую или измененную сущность
        /// </summary>
        /// <param name="item"></param>
        void Save(T item);

        /// <summary>
        /// Удаляет сущность
        /// </summary>
        /// <param name="item"></param>
        void Delete(T item);

        /// <summary>
        /// Сохраняет изменения
        /// </summary>
        int SaveChanges();
    }
}