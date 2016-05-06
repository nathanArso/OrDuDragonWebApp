using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrDuDragon.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nom d'usager")]
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 0)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
    }

    public class User
    {
        public OracleConnection connexion = new OracleConnection();

        private string usr;
        private string passw;
        public User() { }
        public User(UserViewModel userViewModel)
        {
            usr = userViewModel.UserName;
            passw = userViewModel.Password;
        }
        public bool LogIn()
        {
            try
            {
                string dSource = "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 205.237.244.251)"
                    + "(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = orcl.clg.qc.ca)))";
                string chaine = "Data Source =" + dSource + "; User Id =" + usr + ";Password =" + passw;
                connexion.ConnectionString = chaine;
                connexion.Open();
                return true;
            }
            catch (Exception se)
            {
                return false;
            }
        }

        public void LogOut()
        {
            if (connexion.State == ConnectionState.Open)
            {
                connexion.Close();
            }
        }

     
    }
}
