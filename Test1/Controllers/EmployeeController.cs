﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult DisplayName(string name)
        {
            return Content(name);
        }
    }
}