using Cafeteria_Management_System.Models;
using Cafeteria_Management_System.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController:Controller
    {
        private readonly Data data;
        private readonly IVendorRepo vendor;
        private readonly IAppUser appuser;
        private readonly RoleManager<IdentityRole<int>> rolemanager;
        private readonly UserManager<AppUser> userManager;
        private readonly IOrderRepo order;

        public AdminController(Data data, IVendorRepo vendor,IAppUser appuser,RoleManager<IdentityRole<int>> rolemanager, UserManager<AppUser> userManager, IOrderRepo order)
        {
            this.data = data;
            this.vendor = vendor;
            this.appuser = appuser;
            this.rolemanager = rolemanager;
            this.userManager = userManager;
            this.order = order;
        }

        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            List<AppUser> user = await appuser.GetUser();
            var userSelect =user.Where(x => x.Id >= 5);
            return View(userSelect);
        }
       
        public async Task<IActionResult> GetVendors()
        {
            var Vendors = await vendor.GetVendor();
            
            return View(Vendors);
        }


        public ViewResult UpdateVendor(int id)
        {
            Vendor Vent = vendor.GetVendorById(id);
            return View(Vent);

        }


        public async Task<IActionResult> DeleteVendor(int id)
        {
           await  vendor.DeleteVendor(id);
            return RedirectToAction("GetVendors");

        }
        [HttpGet]
        public IActionResult AddVendor()
        {
            return View();
        }
        


        [HttpPost]
        public async Task<IActionResult> AddVendor(Vendor vendo)
        {
            await vendor.AddVendor(vendo);
            TempData["Success"] = "<script> alert('Vendor Added Successfuly')</script>";
            return RedirectToAction("GetVendors");

        }

        [HttpPost]
        public IActionResult UpdateVendor( Vendor vend)
        {
            vendor.UpdateVendor(vend);

            TempData["Success"] = "<script> alert('Update Successful')</script>";
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ViewResult UpdateUser(int id)
        {
            AppUser user = appuser.GetAppUserById(id);
            return View(user);

        }
        [HttpPost]
        public IActionResult UpdateUser(AppUser users)
        {


             appuser.UpdateUser(users);
            return RedirectToAction("GetUsers");

        }

        public  IActionResult DeleteUser(int id)
        {
             appuser.DeleteAppuser(id);
            return RedirectToAction("GetUsers");

        }

        [HttpGet]
        public IActionResult Createrole()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Createrole(CreateRole model )
        {
            if (ModelState.IsValid)
            {

                IdentityRole<int> identityrole = new IdentityRole<int>
                {

                    Name = model.RoleName

                };
                 IdentityResult result = await rolemanager.CreateAsync(identityrole);
               

                if (result.Succeeded)
                {
                    return View();
                }
                foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }


            }

            return View(model);

        }
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = rolemanager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(int id)
        {
            var role = await rolemanager.FindByIdAsync(Convert.ToString(id));
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("NotFound");
            }
            var model = new EditRole
            {
                Id = role.Id,
                RoleName = role.Name,
                
            };

            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);

                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRole model)
        {
            var role = await rolemanager.FindByIdAsync(Convert.ToString( model.Id));
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;
                var result = await rolemanager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
        }


        [HttpGet]
        public async Task<IActionResult> EditUser(int roleId)
        {
            ViewBag.roleId = roleId;

            var role = await rolemanager.FindByIdAsync(Convert.ToString(roleId));

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserModel>();

            foreach (var user in userManager.Users)
            {
                var userModel = new UserModel
                {
                    Id = user.Id,
                    UserName = user.UserName
                };

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userModel.IsSelected = true;
                }
                else
                {
                    userModel.IsSelected = false;
                }

                model.Add(userModel);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(List<UserModel> model, int roleId)
        {
            var role = await rolemanager.FindByIdAsync(Convert.ToString(roleId));

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(Convert.ToString(model[i].Id));
                IdentityResult result = null;
              

                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { Id = roleId });

                }
            }

            return RedirectToAction("EditRole", new { Id = roleId });

        }
        public async Task<IActionResult> GetOrder()
        {
            var orders = await order.GetOrder();
            var result = orders.OrderByDescending(x => x.OrderId);

            return View(result);
        }

    }




}
