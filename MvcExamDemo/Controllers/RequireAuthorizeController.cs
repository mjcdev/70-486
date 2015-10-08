using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamDemo.Controllers
{
    public class RequireAuthorizeController : Controller
    {
        // GET: RequireAuthorize
        // This Action requires Authentication.
        // This attribute can also be applied at the Controller to secure all actions, or globally over the whole app.
        [Authorize]
        public ActionResult Index()
        {
            return Content("This Result Requires Authentication");
        }

        // No Authentication is required for this Action.
        public ActionResult Anonymous()
        {
            return Content("This Result allows Anonymous");
        }
    }
}