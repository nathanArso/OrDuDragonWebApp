using Autentification.Controllers;
using Oracle.DataAccess.Client;
using OrDuDragon.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// TODO :: handle error page create a new view for that
namespace OrDuDragon.Controllers
{
    public class QuestionsController : Controller
    {

        [AuthorisationRequired]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AuthorisationRequired]
        public ActionResult Create()
        {
            Question question = new Question();
            return View(question);
        }

        [HttpPost]
        [AuthorisationRequired]
        public ActionResult Create(Question question)
        {
            User user = (User)Session["User"];

            return RedirectToAction("Index");
        }

    }
}