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

        [Display(Name = "Prénom")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Nom")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer")]
        [Compare("Password", ErrorMessage = "Le mot de passe et celui de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }
    public class User
    {

    }
    public class Users
    {

    }


}
