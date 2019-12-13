using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Areas.Admin.Controllers
{
    public class HomeController:Controller
    {

        public IActionResult AdminLogin()
        {
            return View("AdminLoginView");
        }
    }
}
