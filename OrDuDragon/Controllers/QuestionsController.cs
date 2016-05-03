using Autentification.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrDuDragon.Controllers
{
    public class QuestionsController : Controller
    {

        [AuthorisationRequired]
        public ActionResult Index()
        {
            return View();
        }
    }
}