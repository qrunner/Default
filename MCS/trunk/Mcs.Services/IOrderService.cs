using System.Collections.Generic;
using System;
using Mcs.Model;

namespace Mcs.Services
{
    /// <summary>
    /// Служба заказов
    /// </summary>
    public interface IOrderService : IPlaceServiceBase<Order>
    {                
        IEnumerable<Order> GetByStateAndDates(int placeId, OrderState state, DateTime from, DateTime to, int skip, int take);

        /// <summary>
        /// Меняет количество блюда в заказе
        /// </summary>
        /// <param name="orderId">Идентификатор заказа</param>
        /// <param name="dishId">Идентификатор блюда</param>
        /// <param name="delta">Разница в количестве (для уменьшения - отрицательное число)</param>
        void ChangeDishQuantity(int orderId, int dishId, int delta);
    }
}