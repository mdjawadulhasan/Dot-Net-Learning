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

        public ActionResult ReqExample()
        {
            ViewBag.url = Request.Url;
            ViewBag.PhysicalApplicationPath = Request.PhysicalApplicationPath;
            ViewBag.path = Request.Path;
            return View();
        }


        public ActionResult ResExample()
        {

            Response.Write("Hello !");
            return View();
        }

    }


}