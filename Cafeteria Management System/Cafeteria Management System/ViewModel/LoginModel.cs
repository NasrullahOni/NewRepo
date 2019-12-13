using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Enter your EMailAddress")]
        [EmailAddress]
        
        public string  EmailAdrress { get; set; }

        [Required(ErrorMessage ="Enter Your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
