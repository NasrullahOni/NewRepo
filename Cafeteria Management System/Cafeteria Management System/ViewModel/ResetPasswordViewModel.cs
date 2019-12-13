using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.ViewModel
{
    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password and ConfirmPassword must Match")]
        public string ConfirmPassword { get; set; }
        public string Token { get; set; }
    }
}
