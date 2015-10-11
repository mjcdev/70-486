using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamDemo.Helpers
{
    public static class CustomHelper
    {
        // Extension Method returning MvcHtmlString
        public static MvcHtmlString AddDivs(this HtmlHelper html, string input)
        {
            return new MvcHtmlString(string.Format("{0}{1}{2}", "<div>", input, "</div>"));
        }
    }
}