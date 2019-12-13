using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public Vendor()
        {
            Foods = new List<Foods>();
        }
        public  string VendorName { get; set; }
        public  List<Order> Orders { get; set; }
        public string Name { get; set; } 
        public  string Location { get; set; }
        public string EmailAddress { get; set; }
 
       
        public  List<Foods> Foods { get; set; }

        public DateTime Date { get; set; }

      
        public int? OrderId { get; set; }
        public Order Order { get; set; }
        public Foods Food { get; set; }
        public AppUser AppUser { get; set; }

        public override bool Equals(object obj)
        {
            return this.VendorName == ((Vendor)obj).VendorName;
              
        }
        public override int GetHashCode()
        {
            return this.VendorName.GetHashCode();
        }

    }
}
