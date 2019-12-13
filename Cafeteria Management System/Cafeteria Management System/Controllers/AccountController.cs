using Cafeteria_Management_System.Models;
using Cafeteria_Management_System.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Controllers
{
    
    public class AccountController:Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly ILogger<AccountController> logger;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ILogger<AccountController>logger)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.logger = logger;
        }

        public IActionResult  Index()
        {


            return View();

        }
        
    
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

       
        [HttpPost]
       // [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new AppUser {
                    UserName = model.EMail, StaffId = model.StaffId,
                    Email = model.EMail,
                    Department = model.Department,
                    NormalizedEmail = model.EMail,
                    NormalizedUserName = model.EMail,
                    EmailConfirmed = true,
                    StaffName =model.StaffName  };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);// cookie type; session cookie
                    TempData["Success"] = "<script>alert('Registered successfully')</script>";

                    ModelState.Clear();
                    return  View();
                };
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);

                }
            }
            
            return View(model);
        }
        [HttpGet]
       [AllowAnonymous]
        public IActionResult Login()
        {

            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model, string ReturnUrl)
        {

            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.EmailAdrress, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(ReturnUrl) /*&& Url.IsLocalUrl(ReturnUrl )*/)
                    {
                        return LocalRedirect(ReturnUrl);
                    }
                    else
                   {
                        return RedirectToAction("Index", "Home");
                    }
                };

                ModelState.AddModelError("", "Invalid Details");


            }

            return View(model);
        }
        [AllowAnonymous]  
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();

        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();

        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if(user != null && await userManager.IsEmailConfirmedAsync(user))
                {
                    var token = await userManager.GeneratePasswordResetTokenAsync(user);
                    var passwordResetLink = Url.Action("ResetPassword", "Account", new { email = model.Email, token = token }, Request.Scheme);
                    logger.Log(LogLevel.Warning, passwordResetLink);
                    return View("ForgotPasswordConfirmation");

                }

                return View("ForgotPasswordConfirmation");
            }



            return View(model);

        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string token, string email)

        {
            if(token ==null|| email==null)
            {
                ModelState.AddModelError("", "Invalid Password Reset Token");
                return View();
            }

            return View();

        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)

        {
            if (ModelState.IsValid)

            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await userManager.ResetPasswordAsync(user, model.Token,model.Password);
                    if (result.Succeeded)
                    {
                        return View("ResetPasswordConfirmation");
                    }

                    foreach(var Errors in result.Errors)
                    {
                        ModelState.AddModelError("", Errors.Description);
                    }

                }
                return View("ResetPasswordConfirmation");

            }
           

            return View(model);

        }

        [HttpGet]
       
        public IActionResult ChangePassword()

        {
          

            return View();

        }


        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)

        {
            if (ModelState.IsValid)
            {
                var user = await userManager.GetUserAsync(User);

                if (user == null)
                {
                    RedirectToAction("Login");
                }
                var result = await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);

                if (!result.Succeeded)
                {
                    foreach(var errors in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, errors.Description);
                    }
                    return View();

                }
                await signInManager.RefreshSignInAsync(user);
                return View("ChangePasswordConfirmation");


            }
            return View(model);

        }



    }
}
