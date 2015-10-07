using System.Web.Mvc;
using Mcs.Model;
using Mcs.Services;
using Mcs.WebExtensions;

namespace Mcs.ServerMobile.Controllers
{
    public class CategoryController : EditController<MenuCategory, IPlaceRelatedService<MenuCategory>>
    {
        public ActionResult Index(int id)
        {
            Application.CurrentPlaceId = id;

            return View(ServiceInterface.GetOfPlace(Application.CurrentPlaceId));
        }

    }
}
