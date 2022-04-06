using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotpatPhotoBox.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Addnewproduct()
        {
            return View();
        }
        public ActionResult addressform()
        {
            return View();
        }
        public ActionResult changepasswordform()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Orders()
        {
            return View();
        }
        public ActionResult PoductList()
        {
            return View();
        }
        public ActionResult register()
        {
            return View();
        }
    }
}