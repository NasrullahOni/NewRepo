using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Models
{
    public class AppUser:IdentityUser<int>
    {
        
        public string StaffId { get; set; }
        public string Department { get; set; }
        public string StaffName { get; set; }

        public Order Order { get; set; }

        public override bool Equals(object obj)
        {
            return this.Department == ((AppUser)obj).Department;
        }
        public override int GetHashCode()
        {
            return this.Department.GetHashCode();
        }
    }
}
