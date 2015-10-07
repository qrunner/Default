using System.Web.Mvc;

namespace Mcs.Client.Controllers
{
    public class DishDetailsController : Controller
    {
        readonly Storage.Storage _storage = new Storage.Storage();

        public ActionResult DishDetails(int dishId)
        {
            var dish = _storage.GetDish(dishId);
            return View(dish);
        }
    }
}
