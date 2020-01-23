using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpenseProjectDemo.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "*")]
        public int Userid { get; set; }
        [Required(ErrorMessage = "*")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "*")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
        [Required(ErrorMessage ="*")]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
        
    }
}