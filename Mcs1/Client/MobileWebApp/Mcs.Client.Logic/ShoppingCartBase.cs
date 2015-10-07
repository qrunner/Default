using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mcs.Model;

namespace Mcs.Client.Logic
{
    /// <summary>
    /// Корзина товаров
    /// </summary>
    public class ShoppingCartBase
    {
        readonly Storage.Storage _storage = new Storage.Storage();

        /// <summary>
        /// Идентификтор устройства, к которому привязан элемент корзины
        /// </summary>
        private string DeviceId { get; set; }

        /// <summary>
        /// Создает экземпляр корзины товаров
        /// </summary>
        /// <param name="context">Контекст HTTP-запроса</param>
        /// <returns></returns>
        public static ShoppingCartBase GetCart(HttpContextBase context)
        {
            var cart = new ShoppingCartBase {DeviceId = DeviceIdManager.GetDeviceId(context)};
            return cart;
        }

        /// <summary>
        /// Возвращает список элементов корзины
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Cart> GetCarts()
        {
            return _storage.GetCarts(DeviceId);
        }

        /// <summary>
        /// Возвращает словарь, ключом которого является идентфикатор блюда, значением - предзаказанное количество порций
        /// </summary>
        /// <returns>Словарь, ключом которого является идентфикатор блюда, значением - предзаказанное количество порций</returns>
        public IDictionary<int, int> GetDishQty()
        {
            var carts = _storage.GetCarts(DeviceId);
            return carts.ToDictionary(cart => cart.DishId, cart => cart.Quantity);
        }        

        /// <summary>
        /// Добавляет новое блюдо в корзину, если блюдо уже есть в корзине - увеличивает количество порций на единицу
        /// </summary>
        /// <param name="dishId">Идентификтор блюда</param>
        public int Add(int dishId)
        {
            return _storage.AddToCart(dishId, DeviceId);
        }

        /// <summary>
        /// Удаляет блюдо из корзины, уменьшая количество порций на единицу. Если текущее количество пороций равно единице - удаляет блюдо из корзины
        /// </summary>
        /// <param name="dishId"></param>
        /// <returns></returns>
        public int Remove(int dishId)
        {
            return _storage.RemoveFromCart(dishId, DeviceId);
        }

        /// <summary>
        /// Очищает корзину
        /// </summary>
        public void Clear()
        {
            _storage.ClearCart(DeviceId);
        }
    }
}
