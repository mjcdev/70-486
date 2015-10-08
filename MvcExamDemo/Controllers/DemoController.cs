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
    }
}