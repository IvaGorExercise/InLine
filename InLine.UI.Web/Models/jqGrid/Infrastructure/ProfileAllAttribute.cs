using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
   
    public class ProfileActionAttribute : FilterAttribute, IActionFilter
    {
        private Stopwatch timer;

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            timer.Stop();

            if (filterContext.Exception == null)
            {
                filterContext.HttpContext.Response.Write(
                string.Format("<div>Action method elapsed time: {0}</br></div>", 
               timer.Elapsed.TotalSeconds));
            }
        }
    }

    public class ProfileResultAttribute : FilterAttribute, IResultFilter
    {
        private Stopwatch timer;
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write(
            string.Format("<div>Result elapsed time: {0}</br></div>",
            timer.Elapsed.TotalSeconds));
        }
    }

    public class ProfileAllAttribute : ActionFilterAttribute
    {
        private Stopwatch timer;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write(
            string.Format("<div>Profile Total elapsed time: {0}</br></div>",
            timer.Elapsed.TotalSeconds));
        }
    }
}