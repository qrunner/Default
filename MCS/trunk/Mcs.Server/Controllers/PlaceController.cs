using System;
using System.Web.Mvc;
using Mcs.Model;
using Mcs.Services;
using Mcs.WebExtensions;

namespace Mcs.Server.Controllers
{
    public class PlaceController : EditController<Place, IPlaceService>
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection parameters)
        {
            ActionResult redirect;
            if (ActionResult(parameters, out redirect)) return redirect;
            return View();
        }

        private bool ActionResult(FormCollection parameters, out ActionResult redirect)
        {
            redirect = null;
            try
            {
                Application.CurrentPlaceId = Convert.ToInt32(parameters[0]);

                if (ReturnUrl != null)
                {
                    redirect = Redirect(ReturnUrl);
                    return true;
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                ViewBag.ErrorMessage = "Выберите заведение из списка";
            }
            return false;
        }

        public ActionResult IndexMobile()
        {
            return View(ServiceInterface.Get());
        }

        [HttpPost]
        public ActionResult IndexMobile(FormCollection parameters)
        {
            ActionResult redirect;
            if (ActionResult(parameters, out redirect)) return redirect;
            return View(ServiceInterface.Get());
        }
    }
}
