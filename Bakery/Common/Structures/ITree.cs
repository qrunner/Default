using System.Linq;

namespace Fortius.Structures
{
    /// <summary>
    /// Дерево
    /// </summary>
    /// <typeparam name="T">Тип элемента</typeparam>
    public interface ITree<out T> where T : ITreeNode<T>
    {
        /// <summary>
        /// Корневой элемент
        /// </summary>
        T Root { get; }

        /// <summary>
        /// Все элементы дерева
        /// </summary>
        IQueryable<T> Nodes { get; }
    }
}