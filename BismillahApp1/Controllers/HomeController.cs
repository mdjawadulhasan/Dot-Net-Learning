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

        public ActionResult index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();

        }

        public ActionResult Profile()
        {
            return View();
        }

    }


}