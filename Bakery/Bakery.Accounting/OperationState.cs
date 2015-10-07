namespace Accounting
{
    /// <summary>
    /// Состояние проводки
    /// </summary>
    public enum OperationState
    {
        /// <summary>
        /// Новая
        /// </summary>
        Draft,

        /// <summary>
        /// Проведена
        /// </summary>
        Commited,

        /// <summary>
        /// Сторнирована
        /// </summary>
        Reversed
    }
}
