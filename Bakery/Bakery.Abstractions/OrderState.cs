namespace Bakery.Model
{
    /// <summary>
    /// Статус заказа
    /// </summary>
    public enum OrderState
    {
        /// <summary>
        /// Новый / не обработан
        /// </summary>
        Draft,

        /// <summary>
        /// Взят в работу
        /// </summary>
        TakedToProcess,

        /// <summary>
        /// Выполнен
        /// </summary>
        Executed
    }
}