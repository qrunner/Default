using Fortius.Domain;

namespace Accounting
{
    /// <summary>
    /// Единица измерения
    /// </summary>
    public interface IMeasureUnit : INamedEntity<int>
    {
        /// <summary>
        /// Сокращенное наименование
        /// </summary>
        string ShortName { get; }
    }
}