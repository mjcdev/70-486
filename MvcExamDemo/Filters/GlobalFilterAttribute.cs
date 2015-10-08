using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamDemo.Filters
{
    // Applied this Global Filter in FilterConfig.cs, it will run on all Action and Result Executions.
    public class GlobalFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            Debug.Write("Executed On Action Executing" + Environment.NewLine);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            Debug.Write("Executed On Action Executed" + Environment.NewLine);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {            
            base.OnResultExecuting(filterContext);
            Debug.Write("Executed On Result Executing" + Environment.NewLine);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
            Debug.Write("Executed On Result Executed" + Environment.NewLine);
        }
    }
}