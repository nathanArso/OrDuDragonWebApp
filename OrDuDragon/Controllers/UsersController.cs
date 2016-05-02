using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrDuDragon.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}