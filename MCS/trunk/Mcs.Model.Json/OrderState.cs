namespace Mcs.Model.Json
{
    /// <summary>
    /// Статус заказа
    /// </summary>
    public enum OrderState
    {
        /// <summary>
        /// Заказ в корзине
        /// </summary>
        Draft = 0,

        /// <summary>
        /// Отправлен
        /// </summary>
        Sended = 1,

        /// <summary>
        /// Принят
        /// </summary>
        Accepted = 2,

        /// <summary>
        /// В работе
        /// </summary>
        Processing = 3,

        /// <summary>
        /// Выполнен
        /// </summary>
        Completed = 4,

        /// <summary>
        /// Закрыт
        /// </summary>
        Closed = 5
    }
}