using System.Linq;
using System.Web.Mvc;
using Mcs.Client.Logic;
using Mcs.Client.ViewModels;

namespace Mcs.Client.Controllers
{
    /// <summary>
    /// Контроллер для работы с корзиной
    /// </summary>
    public class ShoppingCartController : Controller
    {
        /// <summary>
        /// Представление: Содержимое корзины
        /// </summary>
        /// <returns>Содержимое корзины (список блюд)</returns>
        public ActionResult ShoppingCart()
        {
            var cartItems = ShoppingCartBase.GetCart(HttpContext).GetCarts().ToList();
            var dishQtyList = cartItems.Select(cart => new DishQty(cart.Dish, cart.Quantity)).ToList();
            return View(dishQtyList);
        }

        /// <summary>
        /// Добавляет новое блюдо в корзину, если блюдо уже есть в корзине - увеличивает количество порций на единицу
        /// </summary>
        /// <param name="id">Идентификтор блюда</param>
        /// <returns>Обновленное количестов порций</returns>
        public ActionResult AddToCart(int id)
        {
            var cart = ShoppingCartBase.GetCart(HttpContext);
            return Json(cart.Add(id));
        }

        /// <summary>
        /// Удаляет блюдо из корзины, уменьшая количество порций на единицу. Если текущее количество пороций равно единице - удаляет блюдо из корзины
        /// </summary>
        /// <param name="id">Идентификтор блюда</param>
        /// <returns>Обновленное количество порций</returns>
        public ActionResult RemoveFromCart(int id)
        {
            var cart = ShoppingCartBase.GetCart(HttpContext);
            return Json(cart.Remove(id));
        }        
    }
}
