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

        public ActionResult GetStudent(int id)
        {
            var students = new[] {
            new { Id = 1, FirstName = "James", LastName = "Bond" },
            new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
            new { Id = 3, FirstName = "Bill", LastName = "Gates" }
            };

            string studentname=null;
            foreach (var items in students)
            {
                if (items.Id == id)
                {
                    studentname = items.FirstName;
                }
            }

            return Content(studentname, "text/plain");

        }
    }


}