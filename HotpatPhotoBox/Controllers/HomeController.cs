using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotpatPhotoBox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        
        public ActionResult Aboutus()
        {
           return View();
        }
        public ActionResult CATEGORY()
        {
            return View();
        }
        public ActionResult checkout()
        {
            return View();
        }
        public ActionResult contactus()
        {
            return View();
        }
        public ActionResult payment()
        {
            return View();
        }
        public ActionResult product()
        {
            return View();
        }
        public ActionResult shop()
        {
            return View();
        }
        public ActionResult yourcartpage()
        {
            return View();
        }

    }
}
