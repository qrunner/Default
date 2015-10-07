using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Mcs.Model;
using Mcs.Services;

namespace Mcs.WebExtensions
{
    public abstract class EditController<T, TServiceInterface> : Controller
        where T : class, IEntity, new()
        where TServiceInterface : class, IServiceBase<T>
    {
        protected TServiceInterface ServiceInterface = Config.ServiceFactory.GetService<TServiceInterface>();

        protected IServiceBase<T> Service { get { return ServiceInterface; } }

        protected virtual void BeforeSave(T item)
        {

        }

        protected virtual void AfterCreate(T item)
        {

        }

        protected virtual void BeforeEdit(T item)
        {

        }

        protected virtual object OverrideViewModel(T item)
        {
            return item;
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Создание";
            var newItem = new T();
            AfterCreate(newItem);
            BeforeEdit(newItem);
            return View("edit", newItem);
        }

        [HttpPost]
        public ActionResult Save(T item, FormCollection parameters)
        {
            try
            {
                BeforeSave(item);

                Service.Save(item);

                HttpPostedFileBase image = Request.Files["image"];
                if (image != null && image.ContentType.StartsWith("image/"))
                {
                    GC.Collect();
                    using (var stream = System.Drawing.Image.FromStream(image.InputStream))
                    {
                        item.SetPicture(stream);
                    }
                }

                return RedirectToReferrer();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("error", (object)ex.Message);
            }
        }

        /*[Authorize(Users = Roles.EditorSupervisor)]*/
        public ActionResult Edit(int id)
        {
            ViewBag.Title = "Редактирование";
            var item = Service.Get(id);
            BeforeEdit(item);
            return View("edit", item);
        }

        public ActionResult Delete(int id)
        {
            var item = Service.Get(id);

            ViewBag.Title = string.Format("Удаление {0}", item);

            return View(item);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection parameters)
        {
            try
            {
                Service.Delete(id);

                return RedirectToReferrer();
            }
            catch (Exception ex)
            {
                return View("error", (object)ex.Message);
            }
        }

        protected ActionResult RedirectToReferrer()
        {
            return ReturnUrl != null ? Redirect(ReturnUrl) as ActionResult : RedirectToAction(RedirectAction, RedirectController) as ActionResult;
        }

        protected virtual string ReturnUrl
        {
            get { return Request.QueryString["returl"]; }
        }

        protected virtual string RedirectController
        {
            get { return this.ControllerContext.RouteData.Values["controller"].ToString(); }
        }

        protected virtual string RedirectAction
        {
            get { return "index"; }
        }
    }
}
