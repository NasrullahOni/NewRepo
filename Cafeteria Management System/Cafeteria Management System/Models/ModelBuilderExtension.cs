using Cafeteria_Management_System.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Models
{
    public static class ModelBuilderExtension
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<AppUser>().HasData(

                                   new AppUser
                                   {
                                       Id = 1,
                                       StaffId = "INI/123",
                                       Department = "Social",
                                       Email = "afeez@yahoo.com",

                                       UserName = "Afeez"
                                   },
                                   new AppUser
                                   {
                                       Id = 2,
                                       StaffId = "INI/246",
                                       Department = "Social",
                                       Email = "kayode@yahoo.com",

                                       UserName = "Olamide"
                                   },
                                    new AppUser
                                    {
                                        Id = 3,
                                        StaffId = "INI/247",
                                        Department = "Social",
                                        Email = "kayode@yahoo.com",

                                        UserName = "Kayode"
                                    },
                                     new AppUser
                                     {
                                         Id = 4,
                                         StaffId = "INI/248",
                                         Department = "Software",
                                         Email = "kayode@yahoo.com",

                                         UserName = "Dele"
                                     },
                                      new AppUser
                                      {
                                          Id = 5,
                                          StaffId = "INI/249",
                                          Department = "CyberAcademy",
                                          Email = "DObam@yahoo.com",

                                          UserName = "David Obafemi Olamide"
                                      }

                                   );

            modelBuilder.Entity<Order>().HasData(

               new
               {
                   OrderId = 1,
                   StaffName = "Afeez",
                   Accepted = "Yes",
                   Date = DateTime.Now.Date,
                   OrderedByMe = "Yes",
                   Food = "Rice, Beans, Plantain",
                   UserId = 1,
                   StaffId = "INI/123",
                   VendorName = "Cuisine Kitchens",
                   VendorId = 1,
                   StaffDepartment = "Social"


               },
                new
                {
                    OrderId = 2,
                    StaffName = "Olamide",
                    Accepted = "Yes",
                    Date = DateTime.Now.Date,
                    OrderedByMe = "Yes",
                    Food = "Rice, EFo, Plantain",
                    VendorId = 1,
                    StaffId = "INI/246",
                    VendorName = "Cuisine Kitchens",
                    UserId = 2,
                    StaffDepartment = "Social"


                },
                 new
                 {
                     OrderId = 3,
                     StaffName = "Olamide",
                     Accepted = "Yes",
                     Date = DateTime.Now.Date,
                     OrderedByMe = "Yes",
                     Food = "Rice, EFo, Plantain",
                     VendorId = 1,
                     StaffId = "INI/246",
                     VendorName = "Cuisine Kitchens",
                     UserId = 2,
                     StaffDepartment = "Social"


                 }

               );


            modelBuilder.Entity<Foods>().HasData(
                new
                {
                    Id = 1,
                    Food = "Semo,Amala,Eba,Poundo-Yam,Rice,Rice&Beans, Jollof-Rice, Jollof-Rice & Beans",
                    Type = "Base-Food",
                    VendorId = 1,

                },
                 new
                 {
                     Id = 2,
                     Food = "EFo, Ewedu, Draw-Soup,Red-Soup",
                     Type = "Soup",
                     VendorId = 1,
                 },
                 new
                 {
                     Id = 3,
                     Food = "Goat-Meat-2, Cow-Meat-2, GoatMeat & Pomo, Cow-Meat & Pomo, Fish-2, Fish & GoatMeat",
                     Type = "Meat",
                     VendorId = 1,

                 },

                  new
                  {
                      Id = 4,
                      Food = "Salad, Cucumber, Carrot, Plantain",
                      Type = "Food-Accessories",
                      VendorId = 1,
                  },
                   new
                   {
                       Id = 5,
                       Food = "Eba,Amala,Eba,FriedRice,Rice,Rice&Beans, Jollof-Rice, Jollof-Rice & Beans",
                       Type = "Base-Food",
                       VendorId = 2,
                   },
                 new
                 {
                     Id = 6,
                     Food = "EFo, Ewedu, Draw-Soup,Red-Soup,Edikaikan",
                     Type = "Soup",
                     VendorId = 2,
                 },
                 new
                 {
                     Id = 7,
                     Food = "Goat-Meat-2, Cow-Meat-2, GoatMeat & Pomo, Cow-Meat & Pomo, Fish-2, Fish & GoatMeat, Chicken",
                     Type = "Meat",
                     VendorId = 2,

                 },

                  new
                  {
                      Id = 8,
                      Food = "Salad, Cucumber, Carrot, Plantain",
                      Type = "Food-Accessories",
                      VendorId = 2,
                  }

               );
            modelBuilder.Entity<Vendor>().HasData(

                new Vendor
                {
                    VendorId = 1,
                    Location = "Aja",
                    EmailAddress = "cuisine@gmail.com",

                    VendorName = "Cuisine Kitchens",

                },
            new
            {
                VendorId = 2,
                Location = "Lekki",
                EmailAddress = "olasko@gmail.com",

                VendorName = "Olasko Kitchens",

            }

                  );


        }
    }
      }
