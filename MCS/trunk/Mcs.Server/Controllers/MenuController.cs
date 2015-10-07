using System.Web.Mvc;
using Mcs.Model;
using Mcs.Server.Models.Menu;
using Mcs.Services;
using Mcs.WebExtensions;

namespace Mcs.Server.Controllers
{
    public class MenuController : Controller
    {
        IPlaceRelatedService<MenuCategory> _categoryService = Config.ServiceFactory.GetService<IPlaceRelatedService<MenuCategory>>();
        IDishService _dishService = Config.ServiceFactory.GetService<IDishService>();

        public ActionResult Index(int? id)
        {
            if (Application.CurrentPlaceId == 0)
                return RedirectToAction("index", "place", new { returl = Request.Url.PathAndQuery });

            if (id.HasValue)
                Application.CurrentCategoryId = id.Value;

            var model = new MenuModel(_categoryService.GetOfPlace(Application.CurrentPlaceId),
                id.HasValue ? _dishService.GetOfCategory(id.Value) : null, id);

            return View(model);
        }
    }
}