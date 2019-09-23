using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            ViewBag.Message = "Login";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Register";

            return View();
        }
    }
}