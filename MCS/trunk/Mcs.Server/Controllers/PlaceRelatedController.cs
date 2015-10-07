using System.Web.Mvc;
using Mcs.Model;
using Mcs.Services;
using Mcs.WebExtensions;

namespace Mcs.Server.Controllers
{
    public class PlaceRelatedController<T> : EditController<T, IPlaceRelatedService<T>> where T:class, IPlaceRelatedEntity, new()
    {
        public ActionResult Index()
        {
            if (Application.CurrentPlaceId == 0)
                return RedirectToAction("index", "place", new { returl = Request.Url.PathAndQuery });

            return View(ServiceInterface.GetOfPlace(Application.CurrentPlaceId));
        }

        public ActionResult IndexMobile(int id)
        {
            Application.CurrentPlaceId = id;
            
            return View(ServiceInterface.GetOfPlace(Application.CurrentPlaceId));
        }
        
        public ActionResult CategoryMobile(int id)
        {
            return View(ServiceInterface.Get(id));
        }

        protected override void AfterCreate(T item)
        {
            base.AfterCreate(item);

            item.PlaceId = Application.CurrentPlaceId;
        }
    }
}