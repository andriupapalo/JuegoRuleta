using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JuegoRuleta.Models
{
    public class Usuario
    {
        private const string VPass = "Password";
        [Required(ErrorMessage = "the Name is Required")]
        [MinLength(5, ErrorMessage = "the Minimun char is five")]
        public string Name { get; set; }
        [EmailAddress]
        [TempData]
        public string Email { get; set; }
        [PasswordPropertyText]
        public String Password { get; set; }
        [PasswordPropertyText]
        [Compare(VPass, ErrorMessage = "Confirm password doesn't match, Type again !")]
        public String Confirm_Password { get; set; }
        [Required]
        public int Credit { get; set; }
    }
}