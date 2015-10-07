namespace Mcs.Model
{
    /// <summary>
    /// Стол
    /// </summary>
    public class Desk : NamedEntity, IPlaceRelatedEntity
    {
        /// <summary>
        /// Идентификатор текущего заказа
        /// </summary>
        public int? CurrentOrderId { get; set; }

        /// <summary>
        /// Идентификатор заведения
        /// </summary>
        public int PlaceId { get; set; }

        /// <summary>
        /// Заведение
        /// </summary>
        public virtual Place Place { get; set; }

        /// <summary>
        /// Зарезервирован
        /// </summary>
        public bool Reserved { get; set; }
    }
}