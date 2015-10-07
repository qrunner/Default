namespace Accounting
{
    /// <summary>
    /// Хранит информацию о стоимости
    /// </summary>
    public interface ICostInfo : ICountInfo
    {
        /// <summary>
        /// Сумма
        /// </summary>
        decimal Amount { get; }
    }
}