using System.Collections.Generic;

namespace Fortius.Structures
{
    public interface IEditableTreeNode<T> : ITreeNode<T> where T : IEditableTreeNode<T>
    {
        new T Parent { get; set; }

        new ICollection<T> ChildItems { get; }
    }
}