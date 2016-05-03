using Autentification.Controllers;
using Oracle.DataAccess.Client;
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
        public ActionResult PermissionInvalide()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(UserViewModel user)
        {
            User userConnected = new User(user);
            if (userConnected.OpenConnexion())
            {
                Session["User"] = userConnected;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [AuthorisationRequired]
        public ActionResult LogOut()
        {
            Session["User"] = null;
            return RedirectToAction("LogIn", "Users");
        }

        [AuthorisationRequired]
        public ActionResult GameData()
        {
            return View();
        }
    }
}