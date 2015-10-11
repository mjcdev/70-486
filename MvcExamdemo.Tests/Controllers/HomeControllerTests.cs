using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcExamDemo.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.CSharp;

namespace MvcExamdemo.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;
                        
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void About()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.About() as ViewResult;

            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void Contact()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Contact() as ViewResult;

            Assert.AreEqual("Your contact page.", result.ViewBag.Message);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
