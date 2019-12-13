using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cafeteria_Management_System.Models
{
    public class SqlRepository : IFoodsRepo, IVendorRepo, IOrderRepo,IAppUser
    {
        private readonly Data data;
       

        public SqlRepository(Data data)
        {
            this.data = data;
        
        }

        public async Task AddFoods(Foods foods)
        {
            data.Foods.Add(foods);
           await data.SaveChangesAsync();
        }

        public async Task AddOrder(Order order)
        {
           await data.Order.AddAsync(order);
          await  data.SaveChangesAsync();
            
        }

        public async Task AddUser(AppUser appuser)
        {
            data.AppUser.Add(appuser);
              await  data.SaveChangesAsync();
        }

        public async Task AddVendor(Vendor vendor)
        {

             data.Vendor.Add(vendor);
           await  data.SaveChangesAsync();
        }

        public void DeleteAppuser(int id)
        {
            data.Remove(data.AppUser.SingleOrDefault(x => x.Id == id));
            data.SaveChanges();
        }

        public void DeleteFoods(int id)
        {
            // Deleting through the DbContext or Dbset
            data.Remove(data.Foods.Single(x => x.Id == id));
            data.SaveChangesAsync();

            /* By setting EntityState
            var beg =  new Foods{Id}
             */
        }

        public void DeleteOrder(int id)
        {
            var res = new Order { OrderId = id };
            data.Entry(res).State = EntityState.Deleted;
            data.SaveChangesAsync();
        }

        public async Task DeleteVendor(int id)
        {
            var vend = new Vendor { VendorId = id };
             data.Remove(vend);
           await  data.SaveChangesAsync();
        }

        public AppUser GetAppUserById(int id)
        {
           return  data.AppUser.SingleOrDefault(x => x.Id == id);
        }

        public List<Foods> GetFoods()
        {
            return data.Foods.ToList();
        }

        public Foods GetFoodsById(int id)
        {
            return data.Foods.SingleOrDefault(x => x.Id == id);
        }

        public Task<List<Order>> GetOrder()
        {
            return Task.FromResult (data.Order.ToList());
        }

        public Order GetOrderById(int id)
        {
            return data.Order.SingleOrDefault(x => x.OrderId == id);
        }

        public async Task<List<AppUser>> GetUser()
        {
            return await data.AppUser.ToListAsync();
        }

        public async Task<List<Vendor>> GetVendor()
        {
            return await data.Vendor.ToListAsync();
        }

        public Vendor GetVendorById(int id)
        {
            return data.Vendor.SingleOrDefault(x => x.VendorId == id);
        }

        public void UpdateFoods(Foods foods)
        {
            data.Update(foods);
            data.SaveChangesAsync();
        }

        public async Task UpdateOrder(Order order)
        {
            data.Update(order);
           await data.SaveChangesAsync();
        }

        public  void UpdateUser(AppUser appuser)
        {
            bool saved = false;

            while (!saved)
            {

                try
                {
                    
                    data.Update(appuser);
                    data.SaveChanges();
                    saved = true;
                }
                catch (DbUpdateConcurrencyException ex)
                {

                    foreach (var entry in ex.Entries)
                    {
                        if (entry.Entity is AppUser)
                        {
                            var proposedValues = entry.CurrentValues;
                            var databaseValues = entry.GetDatabaseValues();

                            foreach (var property in proposedValues.Properties)
                            {
                                var proposedValue = proposedValues[property];
                                var databaseValue = databaseValues[property];

                                // TODO: decide which value should be written to database
                                // proposedValues[property] = <value to be saved>;
                            }

                            // Refresh original values to bypass next concurrency check
                            entry.OriginalValues.SetValues(databaseValues);
                        }
                        else
                        {
                            throw new NotSupportedException(
                                "Don't know how to handle concurrency conflicts for "
                                + entry.Metadata.Name);
                        }
                    }


                }

            }



        }

        public void UpdateVendor(Vendor vendor)
        {
            data.Update(vendor);
            data.SaveChangesAsync();
        }
    }
}
