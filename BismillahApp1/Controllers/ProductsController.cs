using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BismillahApp1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            var producrs = new[]
            {
                new {productid=1,productname="xiomi",cost=23000},
                new {productid=2,productname="Apple",cost=123000}
            };

            if (id == null)
            {
                return Content("Kisu ekta to den vai !");
            }
            else
            {
                string prodname = "";
                foreach (var items in producrs)
                {
                    if (items.productid == id)
                    {
                        prodname = items.productname;
                    }
                }
                return Content(prodname);
            }
        }
    }
}