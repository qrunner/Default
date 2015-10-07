using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mcs.DataModel;
using Mcs.Services;

namespace Mcs.Client.Controllers
{
    public class PlaceController : Controller
    {
        //IPlaceService places = 

        //
        // GET: /Place/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Place/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Place/Create

        public ActionResult Create()
        {
            return View(new Place());
        }

        //
        // POST: /Place/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Place/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Place/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Place/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Place/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
