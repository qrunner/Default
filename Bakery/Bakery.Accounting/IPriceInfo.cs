namespace Accounting
{
    /// <summary>
    /// Хранит информацию о цене за штуку
    /// </summary>
    public interface IPriceInfo
    {
        /// <summary>
        /// Цена за штуку
        /// </summary>
        decimal Price { get; }
    }
}
