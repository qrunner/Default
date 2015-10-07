using Mcs.Model;

namespace Mcs.Client.ViewModels
{
    public class DishQty : Dish
    {
        public DishQty(Dish dish, int quantity)
        {
            Archived = dish.Archived;
            Description = dish.Description;
            DishId = dish.DishId;
            Mcat_Id = dish.Mcat_Id;
            Name = dish.Name;
            Price = dish.Price;
            Quantity = quantity;
        }

        /// <summary>
        /// Предзаказанное количество порций (Количество порций в корзине)
        /// </summary>
        public int Quantity { get; set; }
    }
}