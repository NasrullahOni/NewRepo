using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Models
{
    public class Comparer : IEqualityComparer<AppUser>
    {
        public bool Equals(AppUser x, AppUser y)
        {
            return x.Department == y.Department;
        }

        public int GetHashCode(AppUser obj)
        {
            return obj.Department.GetHashCode();
        }
    }
}
