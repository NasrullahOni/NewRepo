using Cafeteria_Management_System.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria_Management_System.Models
{
    public class Data:IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public Data(DbContextOptions<Data> options) : base(options)
        { 

        }

       

        public DbSet<Order> Order { get; set; }// Dbset property employee to query the instances of the employee class 
        public DbSet<Foods> Foods { get; set; }
        public DbSet<Vendor> Vendor { get; set; }

        public DbSet<AppUser> AppUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();

            // Shadow Property

            modelBuilder.Entity<Order>(m => {
                m.Property<int>("UserId");

            });
           
            modelBuilder.Entity<Order>().Property<string>("VendorName");
            modelBuilder.Entity<Vendor>().Property(s => s.Date).HasDefaultValueSql("GetUtcDate()");

            modelBuilder.Entity<Order>().HasOne(O => O.Vendor)
                .WithOne(e => e.Order).HasForeignKey<Vendor>(v => v.OrderId);        
            modelBuilder.Entity<Foods>().HasOne(f => f.Vendor)
                .WithMany(f => f.Foods).HasForeignKey(x=>x.VendorId).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
         
        }

       

       

    }
}
