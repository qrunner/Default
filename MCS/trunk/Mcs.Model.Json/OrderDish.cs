namespace Mcs.Model.Json
{
    /// <summary>
    /// Блюда в заказе
    /// </summary>
    public class OrderDish// : Entity
    {
       // public int OrderId { get; set; }

        /// <summary>
        /// Идентификатор блюда
        /// </summary>
        public int DishId { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Quantity { get; set; }
    }
}