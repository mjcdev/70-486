using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace MvcExamDemo.Filters
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            Debug.Write("Custom Action Executed" + Environment.NewLine);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            Debug.Write("Custom Action Executing" + Environment.NewLine);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
            Debug.Write("Custom Action Result Executed" + Environment.NewLine);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
            Debug.Write("Custom Action Result Executing" + Environment.NewLine);
        }
    }
}