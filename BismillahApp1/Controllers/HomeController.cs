using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BismillahApp1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View("COMP");
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult StudentInfo()
        {
            ViewBag.studentid = "20-41958-1";
            ViewBag.Name = "MD. JAWADUL HASAN";
            return View();
        }


        

    }


}