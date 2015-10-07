namespace Fortius.Structures
{
    public interface IEditableTree<T> : ITree<T> where T : IEditableTreeNode<T>
    {
        new T Root { get; set; }
    }
}