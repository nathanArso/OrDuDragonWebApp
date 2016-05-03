using OrDuDragon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrDuDragon.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(UserViewModel user)
        {
            Session["User"] = 1;
            return RedirectToAction("Index", "Home");
        }
        public ActionResult LogOut()
        {
            Session["User"] = null;
            return RedirectToAction("LogIn", "Users");
        }
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult GameData()
        {
            return View();
        }
    }
}