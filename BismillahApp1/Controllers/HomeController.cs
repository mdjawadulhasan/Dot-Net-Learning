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

        [Route("Home/index")]
        [Route("")]
        public ActionResult index()
        {
            return View();
        }

        

        [Route("Home/Contact")]
        public ActionResult Contact()
        {
            return View();

        }


        [Route("Profile")]
        public ActionResult Profile()
        {
            return View();
        }

    }


}