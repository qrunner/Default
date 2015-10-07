using System.Linq;
using System.Web.Mvc;
using Mcs.Client.Logic;

namespace Mcs.Client.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult Orders()
        {
            return View();
        }

        public ActionResult SaveOrder()
        {
            var cart = ShoppingCartBase.GetCart(HttpContext);
            var cartItems = cart.GetCarts();
            var orderManager = OrdersManager.GetManager(HttpContext);
            var orderId = orderManager.CreateOrder(cartItems.ToList());
            cart.Clear();
            return View();
        }
    }
}
