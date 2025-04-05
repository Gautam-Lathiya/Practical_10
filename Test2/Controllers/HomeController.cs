using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowContent()
        {
            return Content("This is a ContentResult");
        }

        public ActionResult ShowFile()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/sample.txt"));
            return File(fileBytes, "text/plain", "sample.txt");
        }

        public ActionResult ShowEmpty()
        {
            return new EmptyResult();
        }

        public ActionResult ShowJS()
        {
            return JavaScript("alert('This is JavaScriptResult');");
        }

        public ActionResult ShowJson()
        {
            var data = new { Name = "John", Age = 30 };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}