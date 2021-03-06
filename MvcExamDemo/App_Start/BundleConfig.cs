﻿using System.Web;
using System.Web.Optimization;

namespace MvcExamDemo
{
    // Bundling of Resource Files to reduce footprint on download
    // Bundle up JavaScript and CSS files
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.unobtrusive*"));

            bundles.Add(new ScriptBundle("~/bundles/demo").Include(
                        "~/Scripts/DemoFunctions.js"));

            bundles.Add(new ScriptBundle("~/bundles/demoJQuery").Include(
                        "~/Scripts/DemoJQuery.js"));

            bundles.Add(new ScriptBundle("~/bundles/demoJQueryUi").Include(
                        "~/Scripts/DemoJQueryUi.js"));

            bundles.Add(new ScriptBundle("~/bundles/demoJQueryAjax").Include(
                        "~/Scripts/DemoJQueryAjax.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                      "~/Content/themes/base/all.css"));
        }
    }
}
