using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Models
{
    public interface IFoodsRepo
    {
        List<Foods> GetFoods();

        Task AddFoods(Foods foods);
        void UpdateFoods(Foods foods);
        Foods GetFoodsById(int id);

        void DeleteFoods(int id);

    }


    public interface IOrderRepo
    {
       Task<List<Order>> GetOrder();

        Task AddOrder(Order order);
        Task UpdateOrder(Order order);
        Order GetOrderById(int id);

        void DeleteOrder(int id);

    }

    public interface IVendorRepo
    {
        Task<List<Vendor>> GetVendor();

        Task AddVendor(Vendor vendor);
        void UpdateVendor(Vendor vendor);
        Vendor GetVendorById(int id);

        Task DeleteVendor(int id);

    }

    public interface IAppUser
    {
        Task<List<AppUser>> GetUser();

        Task AddUser(AppUser appuser);
        void UpdateUser(AppUser appuser);
        AppUser GetAppUserById(int id);

        void DeleteAppuser(int id);

    }
}
