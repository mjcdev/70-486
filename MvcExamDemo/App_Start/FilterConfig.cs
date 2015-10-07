using System.Web;
using System.Web.Mvc;

namespace MvcExamDemo
{
    // Filter Config allows Global Filters to be applied to the application
    // Common filters to apply here include HTTPS and Authorize to assert that entire app is covered by HTTPS and...
    // Ensure that users are logged in.
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
