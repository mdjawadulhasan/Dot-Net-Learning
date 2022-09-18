using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BismillahApp1.Models;

namespace BismillahApp1.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Category>categories= db.Categories.ToList();//getting the data from db
            return View(categories);
        }
    }
}