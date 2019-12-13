using Cafeteria_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.ViewModel
{
    public class RegisterViewModel
    {



        [Required]
        [Display(Name = "Enter user StaffId")]
        public string StaffId { get; set; }

        [Required]
        [Display(Name = "Enter user StaffName")]
        public string StaffName { get; set; }


        [Required]
        [Display(Name = "Enter Staff E-MailAddress")]
        [EmailAddress]
        //[Remote(action: "EmailIsInUse", controller: "Account")]

        public string EMail { get; set; }
        [Required]
        [Display(Name = "Enter your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]//Password 
        [Compare("Password", ErrorMessage = "Password does not Match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Department")]
        public string Department { get; set; }
      
       
    }
}
