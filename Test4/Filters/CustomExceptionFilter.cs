using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test4.Filters
{
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            // Mark exception as handled
            filterContext.ExceptionHandled = true;

            // Redirect to Error view
            filterContext.Result = new ViewResult
            {
                ViewName = "Error"
            };
        }
    }
}