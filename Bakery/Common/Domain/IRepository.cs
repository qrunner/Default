using System;
using System.Collections.Generic;
using Fortius.Structures;

namespace Fortius.Domain
{
    /// <summary>
    /// Репозиторий объектов предметной области
    /// </summary>
    public interface IRepository : IUnitOfWork, IDisposable
    {
        /// <summary>
        /// Возвращает набор сущностей заданного типа
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <returns></returns>
        IEntityCollection<T> Collection<T>();

        /// <summary>
        /// Получает значения справочника
        /// </summary>
        /// <typeparam name="T">Тип элемента справочника</typeparam>
        /// <returns></returns>
        IEnumerable<T> Reference<T>() where T:class;

        /// <summary>
        /// Получает древовидный справочник
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        ITree<T> ReferenceTree<T>() where T:ITreeNode<T>;

        /// <summary>
        /// Получает древовидную структуру сущностей
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IEditableTree<T> Tree<T>() where T : IEditableTreeNode<T>;
    }
}