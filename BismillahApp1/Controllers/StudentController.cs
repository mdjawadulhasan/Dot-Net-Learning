using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BismillahApp1.Models;

namespace BismillahApp1.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([ModelBinder(typeof(CustomBinder))] Student stu)
        {
            return View();
        }

    }
}