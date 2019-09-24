using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManagement.Models;

namespace UserManagement.Controllers
{
    public class HomeController : Controller
    {
        UserDatabaseEntities db = new UserDatabaseEntities();
        
        public ActionResult Login()
        {
            ViewBag.Message = "Login";

           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "username,password")] Login login)
        {
            

            return View(login);
        }


        public ActionResult Register()
        {
            ViewBag.Message = "Register";

            return View();
        }
    }
}