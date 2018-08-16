using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductService.Controllers
{
    public class AppPageController : Controller
    {
        // GET: AppPage
        public ActionResult Index()
        {
            return View();
        }

        // GET: AppPage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AppPage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppPage/Create
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

        // GET: AppPage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AppPage/Edit/5
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

        // GET: AppPage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppPage/Delete/5
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
