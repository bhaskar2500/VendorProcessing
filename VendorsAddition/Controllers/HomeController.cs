using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VendorsAddition.Models;

namespace VendorsAddition.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(VendorModel objVendor)
        {
           
            string name=objVendor.ProductName ;
            return View(objVendor);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}