using MvcExamDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamDemo.Controllers
{
    public class ModelDemoController : Controller
    {
        // GET: ModelDemo
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SimpleModel()
        {
            ViewBag.Message = "Displaying model property values in a view.";

            SimpleModel simpleModel = new SimpleModel();
            simpleModel.Location = "Birmingham, UK";
            simpleModel.Name = "Mike Childs";
            simpleModel.Website = "http://mjcdev.co.uk";

            return View("SimpleModel", simpleModel);
        }
    }
}