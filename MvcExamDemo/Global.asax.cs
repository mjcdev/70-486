using MvcExamDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;

namespace MvcExamDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            BundleMobileConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer<LocalDbContext>(new LocalDbInitializer());

            LocalDbContext context = new LocalDbContext();
            context.Database.Initialize(true);

            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("iPhone")
            {
                ContextCondition = (ctx => ctx.GetOverriddenUserAgent().IndexOf("iPhone", StringComparison.OrdinalIgnoreCase) >= 0)
            });

            DisplayModeProvider.Instance.Modes.Insert(1, new DefaultDisplayMode("iPad")
            {
                ContextCondition = (ctx => ctx.GetOverriddenUserAgent().IndexOf("iPad", StringComparison.OrdinalIgnoreCase) >= 0)
            });
        }
    }
}
