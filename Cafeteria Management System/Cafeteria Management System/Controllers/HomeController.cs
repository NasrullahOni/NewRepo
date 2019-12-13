using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cafeteria_Management_System.Models;
using Cafeteria_Management_System.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Cafeteria_Management_System.Controllers
{
 
    public class HomeController : Controller
    {
        private readonly Data data;
        private readonly IVendorRepo vd;
        private readonly IFoodsRepo fd;
        private readonly IOrderRepo rt;
        private readonly IAppUser app;

        public HomeController(Data data,IVendorRepo vd,IFoodsRepo fd,IOrderRepo rt,IAppUser app)
        {
            this.data = data;
            this.vd = vd;
            this.fd = fd;
            this.rt = rt;
            this.app = app;
        }
 
        public IActionResult Index()
        {
            
            return View();
        }

      
        public ViewResult Order() => View();

        
        [HttpPost]
        public async Task<IActionResult> Order(OrdersViewModel model)
        {
            if (ModelState.IsValid)
            {
                var vendor = data.Vendor.Where(x => x.VendorId == model.VendorId);
            var vendorFirstName = vendor.SingleOrDefault();
            string Vendof = vendorFirstName.VendorName;

            var staff = data.AppUser.Where(x => x.StaffId == model.StaffId);
            var sf = staff.FirstOrDefault();
            string Staff = sf.StaffName;

               
               
            var appUser = data.AppUser.Where(x => x.StaffId == model.StaffId);
            var user = appUser.FirstOrDefault();
            var UserId = user.Id;

               string collectorName = null;

                if (string.IsNullOrEmpty(model.Collector))
                {
                    collectorName = "N/A";
                }
                else
                {
                    var collect = data.AppUser.Where(x => x.StaffId == model.Collector).ToList();

                    if (collect.Count <= 0)
                    {
                        collectorName = "Not Valid";
                        ModelState.AddModelError("", "InValid Collector StaffId");
                    }
                    else
                    {
                        collectorName = collect.FirstOrDefault().StaffName;
                    }
                }




                //    var collect = data.AppUser.Where(x => x.StaffId == model.Collector).ToList();

                //    if(collect.Count <= 0)
                //{
                //    collectorName = "Not Valid";
                //    ModelState.AddModelError("", "InValid Collector StaffId");
                //}
                //else
                //{
                //    collectorName = collect.FirstOrDefault().StaffName;
                //}


                var sed = new Order
            {
                OrderedByMe = model.OrderedByMe,
                Food = model.FoodOrdered,
                VendorName = Vendof,
                VendorId = model.VendorId,
                Date = model.Date,
                StaffId = model.StaffId,
                StaffName = Staff,
                StaffDepartment = sf.Department,
                Collector = collectorName

            };
            
                var Order = await rt.GetOrder();
               var  result = Order.Where(x => x.StaffId == model.StaffId && DateTime.Compare(x.Date.Value, DateTime.Now.Date)==0 ).ToList();

                if (result.Count <=0)
                {
                    var res = TempData["Confirm"];
                    data.Entry(sed).Property("UserId").CurrentValue = UserId;
                    
                    await rt.AddOrder(sed);

                    TempData["Confirm"] = "<script> confirm('Are you sure you want to proceed with the order')</script>";

                    return RedirectToAction("OrderConfirmation", sed);             
                }
                else
                {
                    ModelState.AddModelError("", "Sorry You Can no longer make Order");
                   
                    
                    return View();
                }

            }
           
            return View();
        }

        public IActionResult  OrderConfirmation (Order model)
        {
            var result = model;
            return View(result);
        }
      
        [HttpGet]
        public async Task<IActionResult> OrderHistory(string name)
        {
            var ans = await rt.GetOrder();

            var history = ans.Where(x => x.StaffName == name).OrderByDescending(x => x.OrderId);
            
            
                return View(history);
            
       
        }
       
        public ActionResult GetSub(int id)
        {       
                var des = data.Foods.Select(x => new
            {
                BaseFood = data.Foods.Where(t => t.Type == "Base-Food" && t.VendorId == id),
                Soup = data.Foods.Where(y => y.Type == "Soup" && y.VendorId == id),
                Meat = data.Foods.Where(z => z.Type == "Meat" && z.VendorId == id),
                FoodAccessories = data.Foods.Where(K => K.Type == "SideDish" && K.VendorId == id)
            });

           
            return Json(des);
        }

        public  ActionResult GetDept(string id)
        {
            var des =  data.AppUser.Where(x => x.Department == id).Select(x => x.StaffId);
           
            return Json(des);

        }

        [HttpGet]
        public  async Task<IActionResult> GetOrder()
        {
            var sed = await rt.GetOrder();
            var res = sed.ToList();

            return View(res);

            
        }

    }
  

}
