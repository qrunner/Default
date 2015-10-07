using System.Web.Mvc;
using System.Web.Security;
using Mcs.Server.Models.Account;

namespace Mcs.Server.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/LogOn
        [AllowAnonymous]
        public ActionResult LogOn()
        {
            LogOnViewModel model = new LogOnViewModel();

            return View(model);
        }

        //
        // POST: /Account/LogOn
        [AllowAnonymous]
        [HttpPost]
        public ActionResult LogOn(LogOnViewModel model, string returnUrl)
        {
            if (this.ModelState.IsValid && FormsAuthentication.Authenticate(model.UserName, model.Password))
            {
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                if (this.Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            // If we got this far, something failed, redisplay form
            this.ModelState.AddModelError("", "Incorrect user name or password.");
            return View(model);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }
    }
}
