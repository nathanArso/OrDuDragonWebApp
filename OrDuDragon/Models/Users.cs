using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [StringLength(50, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

    }
    public class User
    {

    }
    public class Users
    {

    }


}
