using MvcExamDemo.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.UI;

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

        public ActionResult HtmlHelpers()
        {
            return View();
        }

        public ActionResult UsingPartialViews()
        {
            return View();
        }

        public ActionResult JQueryUi()
        {
            return View();
        }

        public ActionResult JQuery()
        {
            ViewBag.Message = "Modifying UI with JQuery";
            return View();
        }

        public ActionResult JQueryAjax()
        {
            ViewBag.Message = "JQuery Ajax";
            return View();
        }

        public ActionResult JQueryAjaxEndpoint()
        {
            ViewBag.Message = "JQuery Ajax Endpoint";
            return View();
        }

        public PartialViewResult JQueryAjaxPartial()
        {
            ViewBag.Details = "Information Here";
            return PartialView("_JQueryAjaxPartial");
        }

        public ActionResult AjaxHelper()
        {
            ViewBag.Title = "Ajax Helper";
            ViewBag.PageContent = "Ajax Helper Page";
            return View("AjaxHelper");
        }

        [OutputCache(Duration = 20,
            Location = OutputCacheLocation.Any,
            VaryByCustom = "browser",
            VaryByParam = "none")]
        public ActionResult OutputCache()
        {
            ViewBag.Message = DateTime.Now.ToString();
            return View();
        }

        public ActionResult HttpCache()
        {
            ViewBag.Message = DateTime.Now.ToString();
            return View();
        }

        [OutputCache(Duration = 20,
            Location = OutputCacheLocation.Any,
            VaryByCustom = "browser",
            VaryByParam = "none")]
        public ActionResult DynamicCache()
        {
            ViewBag.Message = DateTime.Now.ToString();
            return View();
        }

        [OutputCache(CacheProfile="shortCache")]
        public ActionResult OutputCacheProfile()
        {
            ViewBag.Message = DateTime.Now.ToString();
            return View();
        }
    }
}