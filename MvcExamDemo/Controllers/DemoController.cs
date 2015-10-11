using MvcExamDemo.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return Content("Demo Index");
        }

        [ActionName("Alias")]
        public ActionResult AliasedAction()
        {
            return Content("This Action is accessible via it's alias - Alias.");
        }
        
        [CustomActionFilter]
        public ActionResult CustomActionFilter()
        {
            return Content("Custom Action Filter Overrides Firing on this Action");
        }

        public ActionResult ViewBagAction()
        {
            ViewBag.TestViewBagProperty = "Adding to the ViewBag";
            ViewBag.TestBoolProperty = true;
            return View();
        }

        public ActionResult RazorSyntax()
        {
            return View();
        }

        public ActionResult InlineRazorSyntax()
        {
            return View();
        }
    }
}