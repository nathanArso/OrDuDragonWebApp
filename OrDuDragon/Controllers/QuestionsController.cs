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

            try
            {
                //   PROCEDURE INSERTQUESTION(PENONCER IN QUESTION.ENONCER%TYPE,PDIFFICULTER IN QUESTION.DIFFICULTER%TYPE);

                // Ajout de la question
                OracleCommand oraclCommandAjoutQuestion = new OracleCommand("GESTIONQUESTION", user.connexion);
                oraclCommandAjoutQuestion.CommandText = "GESTIONQUESTION.INSERTQUESTION";
                oraclCommandAjoutQuestion.CommandType = CommandType.StoredProcedure;

                OracleParameter orapamnumEnoncer = new OracleParameter("PENONCER", OracleDbType.Varchar2, 100);
                orapamnumEnoncer.Direction = ParameterDirection.Input;
                orapamnumEnoncer.Value = question.Enoncer;
                oraclCommandAjoutQuestion.Parameters.Add(orapamnumEnoncer);

                OracleParameter orapamDificulter = new OracleParameter("PDIFFICULTER", OracleDbType.Int32);
                orapamDificulter.Direction = ParameterDirection.Input;
                orapamDificulter.Value = question.Dificulter;
                oraclCommandAjoutQuestion.Parameters.Add(orapamDificulter);

                oraclCommandAjoutQuestion.ExecuteNonQuery();

                // ########################################################################################################################################

                //  PROCEDURE INESRTREPONSE(PENONCER IN REPONSE.ENONCERREPONSE%TYPE,PBONNE IN REPONSE.ESTBONNE%TYPE,PNUMQUESTION IN REPONSE.NUMQUESTION%TYPE);

                // Ajout des choix de réponce
                OracleCommand oraclCommandAjoutReponce = new OracleCommand("GESTIONQUESTION", user.connexion);
                oraclCommandAjoutReponce.CommandText = "GESTIONQUESTION.INESRTREPONSE";
                oraclCommandAjoutReponce.CommandType = CommandType.StoredProcedure;

                // Enoncer
                oraclCommandAjoutReponce.Parameters.Add(orapamnumEnoncer);




                oraclCommandAjoutReponce.ExecuteNonQuery();

                return RedirectToAction("Index");
            }
            catch (Exception ex) {
                return RedirectToAction("Index");
            }
        }

    }
}