using System.Web.Mvc;

namespace Mcs.Server.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //
        // GET: /StartPage/

        public ActionResult Index()
        {           
            return View();
        }
    }
}
