using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BismillahApp1.Models;

namespace BismillahApp1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            List<Product> products = db.Products.Where(temp=>temp.CategoryID==1 && temp.Price>=50000).ToList();
            return View(products);
        }
    }
}