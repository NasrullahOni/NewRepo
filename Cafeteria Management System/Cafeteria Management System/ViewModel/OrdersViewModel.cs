using Cafeteria_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.ViewModel
{
    public class OrdersViewModel
    {
        public string FoodOrdered {
            get => FoodBase + "," + Soup + "," + Meat + "," + SideDish;
                
                }
        public int OrderId { get; set; }
       
        public string Department { get; set; }
        
        public string FoodBase { get; set; }
        public string Soup { get; set; }
        public string SideDish { get; set; }
        public  string Meat { get; set; }
        [Required(ErrorMessage = "Input Your Id")]
        public string OrderedByMe { get; set; }
        public string OrderedByAnother { get; set; }
        public DateTime Date { get; set; } = DateTime.Now.Date;
        public string Accepted { get; set; }
        public string  staffDepartment  { get; set; }
        public string StaffName { get; set; }
       
        public string Collector { get; set; }
        public string Food { get; set; }
        public string StaffId { get; set; }
      
        public string VendorName { get; set; }
        //public Vendor MainCategory { get; set; }

        public List<string> Dropdown { get; set; }
        public int VendorId { get; set; }
        public string  Type { get; set; }
        //public List<Foods> Subcategory { get; set; }
        //public Foods Foods { get; set; }
        //public AppUser AppUser { get; set; }
        public Vendor Vendor { get; set; }
    }
}
