using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task3.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 300)] // 5 minutes = 300 seconds
        public ActionResult Index()
        {
            string currentTime = DateTime.Now.ToString();
            return Content("Cached Time: " + currentTime);
        }

    }
}