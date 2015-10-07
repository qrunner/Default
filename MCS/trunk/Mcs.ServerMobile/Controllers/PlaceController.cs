using System.Web.Mvc;
using Mcs.Model;
using Mcs.Services;
using Mcs.WebExtensions;

namespace Mcs.ServerMobile.Controllers
{
    public class PlaceController : EditController<Place, IPlaceService>
    {
        public ActionResult Index()
        {
            return View(ServiceInterface.Get());
        }

    }
}
