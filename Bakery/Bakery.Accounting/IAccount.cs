using Fortius.Domain;

namespace Accounting
{
    /// <summary>
    /// Счет
    /// </summary>
    public interface IAccount : INamed, IEntity<int>
    {
        /// <summary>
        /// Значение / баланс счета
        /// </summary>
        decimal Value { get; }
        
        /// <summary>
        /// Обновляет значение / баланс счета
        /// </summary>
        /// <param name="delta">Величина изменения</param>
        void Update(decimal delta);
    }
}