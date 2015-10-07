using System.Collections.Generic;

namespace Fortius.Structures
{
    /// <summary>
    /// Представляет элемент древовидной структуры
    /// </summary>
    public interface ITreeNode<T> where T : ITreeNode<T>
    {
        /// <summary>
        /// Родительский элемент
        /// </summary>
        T Parent { get; }

        /// <summary>
        /// Дочерние элементы
        /// </summary>
        ICollection<T> ChildItems { get; }
    }
}