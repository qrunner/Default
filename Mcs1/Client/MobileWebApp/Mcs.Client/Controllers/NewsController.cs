using System.Web.Mvc;

namespace Mcs.Client.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult News()
        {
            return View();
        }
    }
}
