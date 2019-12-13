using Cafeteria_Management_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Controllers
{
 
   
    public class VendorController:Controller
    {
        private readonly IOrderRepo order;
        private readonly IFoodsRepo foods;
        private readonly SignInManager<AppUser> signInManager;
       
        private readonly IVendorRepo vend;

        public VendorController(IOrderRepo order, IFoodsRepo foods, SignInManager<AppUser> signInManager, IVendorRepo vend)
        {
            this.order = order;
            this.foods = foods;
            this.signInManager = signInManager;
           
            this.vend = vend;
        }

        public  IActionResult Index()

        {

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AcceptOrder(int id)
        {
            Order ordere = order.GetOrderById(id);
            ordere.Accepted = "YES";
            
           await order.UpdateOrder(ordere);
            var ans = await vend.GetVendor();
            var sew = ans.Where(x => x.VendorName == ordere.VendorName).FirstOrDefault().EmailAddress;
            return RedirectToAction("GetOrder", "Vendor", new { Email= sew});

        }
        [HttpGet]
        public async Task<IActionResult> RevertOrder(int id)
        {
            Order ordere = order.GetOrderById(id);
            ordere.Accepted = "NO";
           
           await order.UpdateOrder(ordere);
            var ans = await vend.GetVendor();
            var sew = ans.Where(x => x.VendorName == ordere.VendorName).FirstOrDefault().EmailAddress;
            return RedirectToAction("GetOrder","Vendor",new { Email = sew});

        }
        [HttpGet]
        public async Task<IActionResult> GetOrder(string Email)
        {

            var ans = await vend.GetVendor();
            var des = ans.Where(x => x.EmailAddress == Email).FirstOrDefault();
            var res = des.VendorName;
            var answer = await order.GetOrder();
            var result = answer.Where(x => x.VendorName == res).OrderByDescending(x=>x.OrderId);
            //var orders = await order.GetOrder();
            //var result = orders.OrderByDescending(x => x.OrderId);

            return View(result);
        }

        
        public async Task<IActionResult> OrderHistory()
        {
            var orders = await order.GetOrder();
            var result = orders.OrderByDescending(x => x.OrderId);

            return View(result);
        }
        public  IActionResult GetFoods(int id)
        {


            var getfoods = foods.GetFoods().Where(x => x.VendorId == id);

            return View(getfoods);

            //var orders = await order.GetOrder();
            //var result = orders.OrderByDescending(x => x.OrderId);

            //return View(result);
        }
        public IActionResult GetAll()
        {
            var cad =foods.GetFoods();

            return View(cad);
        }

        public IActionResult delGetAll(int id)
        {
            foods.DeleteFoods(id);

            return RedirectToAction("GetAll", "Vendor");
        }

        public IActionResult EditFoods( int id)
        {
            var foodEdit = foods.GetFoodsById(id);

            return View(foodEdit);
        }
        //[HttpGet]
        //public IActionResult GetFoods()
        //{
        //    var dfoods = foods.GetFoods();
        //    return View(dfoods);
        //}


        //public IActionResult DeleteFoods(int id)
        //{
        //    var foodEdit = foods.GetFoodsById(id);

        //    return View();
        //}
        [HttpPost]
        public IActionResult UpdateFoods(Foods gfoods)
        {
            foods.UpdateFoods(gfoods);
            return RedirectToAction("GetFoods",new { id = gfoods.Id});        
        }
        [HttpGet]
        public IActionResult AddFoods()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddFoods(Foods gfoods)
        {
           await foods.AddFoods(gfoods);
          
           
            //ModelState.Clear();
            return RedirectToAction("GetFoods", new { id = gfoods.VendorId });
        }

        public IActionResult DeleteFoods(int Id)
        {
             foods.DeleteFoods(Id);
            return RedirectToAction("GetFoods");
        }



    }
}
