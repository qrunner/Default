namespace Mcs.Model.Json
{
    /// <summary>
    /// Стол
    /// </summary>
    public class Desk : NamedEntity
    {
        /// <summary>
        /// Идентификатор заведения
        /// </summary>
        public int PlaceId { get; set; }

        /// <summary>
        /// Зарезервирован
        /// </summary>
        public bool Reserved { get; set; }

        /// <summary>
        /// Идентификатор текущего заказа
        /// </summary>
        public int? CurrentOrderId { get; set; }
    }
}