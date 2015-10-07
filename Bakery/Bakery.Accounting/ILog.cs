using System.Linq;

namespace Accounting
{
    /// <summary>
    /// Журнал
    /// </summary>
    public interface ILog<T> where T : IEntry
    {
        string Name { get; }

        T New();

        void Append(T record);

        void RemoveByOperation(OperationInfo operationInfo);

        IQueryable<T> Records { get; }
    }
}