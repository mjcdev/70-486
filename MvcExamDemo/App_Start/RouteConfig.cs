using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcExamDemo
{
    // Route Config allows you to register routes to controllers.
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // Routes requests for the RequireAuthorize controller, with a variable Action and Id
            routes.MapRoute(
                name: "RequireAuthorize",
                url: "controller/{action}/{id}",
                defaults: new { controller = "RequireAuthorize", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Demo",
                url: "controller/{action}/{id}",
                defaults: new { controller = "Demo", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ModelDemo",
                url: "controller/{action}/{id}",
                defaults: new { controller = "ModelDemo", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
