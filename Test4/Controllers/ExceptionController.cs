using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test4.Filters;

namespace Test4.Controllers
{
    [CustomExceptionFilter]
    public class ExceptionController : Controller
    {
        // GET: Exception
        public ActionResult Index()
        {
            int a = 0;
            int result = 1 / a; 
            return View();
        }
    }
}