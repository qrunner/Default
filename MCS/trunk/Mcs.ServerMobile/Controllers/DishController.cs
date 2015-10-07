using System.Web.Mvc;
using Mcs.Model;
using Mcs.Services;
using Mcs.WebExtensions;

namespace Mcs.ServerMobile.Controllers
{
    public class DishController : EditController<Dish, IDishService>
    {
        public ActionResult Index(int id)
        {
            return View(ServiceInterface.GetOfCategory(id));
        }

    }
}
