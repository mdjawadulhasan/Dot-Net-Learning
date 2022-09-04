using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BismillahApp1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string uname, string pass)
        {
            if (uname == "ishan" && pass == "123")
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                return RedirectToAction("InvalidLogin");
            }
           
        }

        public ActionResult InvalidLogin(string uname, string pass)
        {
            return View();
        }
    }
}