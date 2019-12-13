using Cafeteria_Management_System.Controllers;
using Cafeteria_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Models
{
    public class Order    {
       [Key]
        public int OrderId { get; set; }
        public string Food { get; set; }
        [Required(ErrorMessage = "Input Your Id")]
        public string OrderedByMe { get; set; }  
        public DateTime? Date { get; set; } 
        public string Accepted { get; set; }
        public  string StaffName { get; set; }
        public  string VendorName { get; set; }
        public  string StaffId  { get; set; }
        public string StaffDepartment { get; set; }
        public string  Collector { get; set; }
        [NotMapped]
        public string CheckedByMe { get; set; } = "CheckedByMe";
        [NotMapped]
        public string NotCheckedByMe { get; set; } = "NotCheckedByMe";

        public int VendorId { get; set; }
        [NotMapped]
        public bool Checked { get; set; }

        public Foods Foods { get; set; }
        
        public Vendor Vendor { get; set; }
    }
}
