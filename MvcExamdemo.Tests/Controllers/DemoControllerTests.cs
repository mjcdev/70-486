using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcExamDemo.Controllers;
using System.Web.Mvc;

namespace MvcExamdemo.Tests.Controllers
{
    [TestClass]
    public class DemoControllerTests
    {
        [TestMethod]
        public void AliasedAction()
        {
            DemoController controller = new DemoController();

            ContentResult result = controller.AliasedAction() as ContentResult;

            Assert.AreEqual("This Action is accessible via it's alias - Alias.", result.Content);
        }
        
        [TestMethod]
        public void CustomActionFilter()
        {
            DemoController controller = new DemoController();

            ContentResult result = controller.CustomActionFilter() as ContentResult;

            Assert.AreEqual("Custom Action Filter Overrides Firing on this Action", result.Content);
        }

        [TestMethod]
        public void ViewBagAction()
        {

            DemoController controller = new DemoController();

            ViewResult result = controller.ViewBagAction() as ViewResult;

            Assert.AreEqual("Adding to the ViewBag", result.ViewBag.TestViewBagProperty);
            Assert.AreEqual(true, result.ViewBag.TestBoolProperty);
        }
    }
}
