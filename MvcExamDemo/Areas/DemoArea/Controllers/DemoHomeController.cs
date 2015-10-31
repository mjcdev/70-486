using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamDemo.Areas.DemoArea.Controllers
{
    public class DemoHomeController : Controller
    {
        // GET: DemoArea/Home
        public ActionResult Index()
        {
            var area = ControllerContext.RouteData.DataTokens["area"];
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];

            ViewBag.Area = area;
            ViewBag.Controller = controller;
            ViewBag.Action = action;

            return View();
        }

        // GET: DemoArea/Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DemoArea/Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DemoArea/Home/Create
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

        // GET: DemoArea/Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DemoArea/Home/Edit/5
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

        // GET: DemoArea/Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DemoArea/Home/Delete/5
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
