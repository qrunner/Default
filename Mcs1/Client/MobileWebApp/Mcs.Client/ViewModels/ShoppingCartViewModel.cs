using System.Collections.Generic;
using Mcs.Model;

namespace Mcs.Client.ViewModels
{
    /// <summary>
    /// Содержит элементы корзины
    /// </summary>
    public class ShoppingCartViewModel
    {
        /// <summary>
        /// Элементы корзины
        /// </summary>
        public List<Cart> CartItems { get; set; }

        /// <summary>
        /// Количество элементов в корзине
        /// </summary>
        public decimal CartTotal { get; set; }
    }
}