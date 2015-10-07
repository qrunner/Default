using System;
using System.Collections.Generic;
using System.Linq;

namespace Mcs.Model
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order : Entity, IPlaceRelatedEntity
    {
        public Order()
        {
            Dishes = new List<OrderDish>();
        }

        /// <summary>
        /// Идентификатор заведения
        /// </summary>
        public int PlaceId { get; set; }

        /// <summary>
        /// Идентификатор стола
        /// </summary>
        public int DeskId { get; set; }

        /// <summary>
        /// Стол
        /// </summary>
        public virtual Desk Desk { get; set; }

        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        public int DeviceId { get; set; }

        /// <summary>
        /// Список блюд в заказе
        /// </summary>
        public virtual ICollection<OrderDish> Dishes { get; set; }

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

        /// <summary>
        /// Общая сумма заказа
        /// </summary>
        public decimal Amount
        {
            get { return Dishes.Sum(x => x.Quantity*x.Dish.Price); }
        }
    }
}