using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace TestFilterApp.Filters
{
    public class CustomActionFilter : ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.OnActionExecuting = "Custom Filter called Executing";
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception != null)
            {
                filterContext.Controller.ViewBag.OnException = "Custom Filter Exception called";
            }

            filterContext.Controller.ViewBag.OnActionExecuted = "Custom Filter called Executed";
            base.OnActionExecuted(filterContext);
        }
    }
}