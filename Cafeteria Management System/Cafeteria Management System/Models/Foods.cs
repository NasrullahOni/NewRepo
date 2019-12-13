using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Models
{
   
    public class Foods
    {
        public int Id { get; set; }
        public string Food { get; set; }
        public string Type { get; set; }
        [NotMapped]
        public AppUser AppUser { get; set; }
        public int? VendorId { get; set; }
        public Vendor Vendor { get; set; }


        public override bool Equals(object obj)
        {
            return this.Type == ((Foods)obj).Type;

        }
        public override int GetHashCode()
        {
            return this.Type.GetHashCode();
        }
    }
}
