using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.ViewModel
{
    public class EditRole
    {
        public EditRole()
        {
            Users = new List<string>();
        }

        public int  Id { get; set; }
        public  string RoleName { get; set; }
        public List<string> Users { get; set; }

    }
}
