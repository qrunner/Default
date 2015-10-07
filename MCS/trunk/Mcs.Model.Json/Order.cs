using System;

namespace Mcs.Model.Json
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order : Entity
    {
        /// <summary>
        /// Идентификатор заведения
        /// </summary>
        public int PlaceId { get; set; }

        /// <summary>
        /// Идентификатор стола
        /// </summary>
        public int DeskId { get; set; }

        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        public int DeviceId { get; set; }

        /// <summary>
        /// Список блюд в заказе
        /// </summary>
        public OrderDish[] Dishes { get; set; }

        /// <summary>
        /// Состояние заказа
        /// </summary>
        public OrderState State { get; set; }

        /// <summary>
        /// Открыт
        /// </summary>
        public DateTime? Opened { get; set; }

        /// <summary>
        /// Закрыт
        /// </summary>
        public DateTime? Closed { get; set; }
    }
}