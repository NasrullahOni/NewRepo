﻿// <auto-generated />
using System;
using Cafeteria_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cafeteria_Management_System.Migrations
{
    [DbContext(typeof(Data))]
    [Migration("20191028005610_test6")]
    partial class test6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cafeteria_Management_System.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Department");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<int?>("OrderId");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("StaffId");

                    b.Property<string>("StaffName");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("OrderId");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a1230232-cfcb-4cce-acd6-273ebc5e786f",
                            Department = "Social",
                            Email = "afeez@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            StaffId = "INI/123",
                            TwoFactorEnabled = false,
                            UserName = "Afeez"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a4c3f783-eb8c-4a6a-9436-af9d33edd3cf",
                            Department = "Social",
                            Email = "kayode@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            StaffId = "INI/246",
                            TwoFactorEnabled = false,
                            UserName = "Olamide"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cb305d96-b7d7-4a92-8675-b7bf363c9d92",
                            Department = "Social",
                            Email = "kayode@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            StaffId = "INI/247",
                            TwoFactorEnabled = false,
                            UserName = "Kayode"
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6be6f2b8-05ec-408a-bf3b-1d2f100e72e0",
                            Department = "Software",
                            Email = "kayode@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            StaffId = "INI/248",
                            TwoFactorEnabled = false,
                            UserName = "Dele"
                        },
                        new
                        {
                            Id = 5,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7d7ec725-b8d2-49fd-95db-45b7819c6647",
                            Department = "CyberAcademy",
                            Email = "DObam@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            StaffId = "INI/249",
                            TwoFactorEnabled = false,
                            UserName = "David Obafemi Olamide"
                        });
                });

            modelBuilder.Entity("Cafeteria_Management_System.Models.Foods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Food");

                    b.Property<string>("Type");

                    b.Property<int?>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Food = "Semo,Amala,Eba,Poundo-Yam,Rice,Rice&Beans, Jollof-Rice, Jollof-Rice & Beans",
                            Type = "Base-Food",
                            VendorId = 1
                        },
                        new
                        {
                            Id = 2,
                            Food = "EFo, Ewedu, Draw-Soup,Red-Soup",
                            Type = "Soup",
                            VendorId = 1
                        },
                        new
                        {
                            Id = 3,
                            Food = "Goat-Meat-2, Cow-Meat-2, GoatMeat & Pomo, Cow-Meat & Pomo, Fish-2, Fish & GoatMeat",
                            Type = "Meat",
                            VendorId = 1
                        },
                        new
                        {
                            Id = 4,
                            Food = "Salad, Cucumber, Carrot, Plantain",
                            Type = "Food-Accessories",
                            VendorId = 1
                        },
                        new
                        {
                            Id = 5,
                            Food = "Eba,Amala,Eba,FriedRice,Rice,Rice&Beans, Jollof-Rice, Jollof-Rice & Beans",
                            Type = "Base-Food",
                            VendorId = 2
                        },
                        new
                        {
                            Id = 6,
                            Food = "EFo, Ewedu, Draw-Soup,Red-Soup,Edikaikan",
                            Type = "Soup",
                            VendorId = 2
                        },
                        new
                        {
                            Id = 7,
                            Food = "Goat-Meat-2, Cow-Meat-2, GoatMeat & Pomo, Cow-Meat & Pomo, Fish-2, Fish & GoatMeat, Chicken",
                            Type = "Meat",
                            VendorId = 2
                        },
                        new
                        {
                            Id = 8,
                            Food = "Salad, Cucumber, Carrot, Plantain",
                            Type = "Food-Accessories",
                            VendorId = 2
                        });
                });

            modelBuilder.Entity("Cafeteria_Management_System.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accepted");

                    b.Property<string>("Collector");

                    b.Property<DateTime?>("Date");

                    b.Property<string>("Food");

                    b.Property<int?>("FoodsId");

                    b.Property<string>("OrderedByMe")
                        .IsRequired();

                    b.Property<string>("StaffDepartment");

                    b.Property<string>("StaffId");

                    b.Property<string>("StaffName");

                    b.Property<int>("UserId");

                    b.Property<int>("VendorId");

                    b.Property<string>("VendorName");

                    b.HasKey("OrderId");

                    b.HasIndex("FoodsId");

                    b.HasIndex("VendorId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            Accepted = "Yes",
                            Date = new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Food = "Rice, Beans, Plantain",
                            OrderedByMe = "Yes",
                            StaffDepartment = "Social",
                            StaffId = "INI/123",
                            StaffName = "Afeez",
                            UserId = 1,
                            VendorId = 1,
                            VendorName = "Cuisine Kitchens"
                        },
                        new
                        {
                            OrderId = 2,
                            Accepted = "Yes",
                            Date = new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Food = "Rice, EFo, Plantain",
                            OrderedByMe = "Yes",
                            StaffDepartment = "Social",
                            StaffId = "INI/246",
                            StaffName = "Olamide",
                            UserId = 2,
                            VendorId = 1,
                            VendorName = "Cuisine Kitchens"
                        },
                        new
                        {
                            OrderId = 3,
                            Accepted = "Yes",
                            Date = new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Food = "Rice, EFo, Plantain",
                            OrderedByMe = "Yes",
                            StaffDepartment = "Social",
                            StaffId = "INI/246",
                            StaffName = "Olamide",
                            UserId = 2,
                            VendorId = 1,
                            VendorName = "Cuisine Kitchens"
                        });
                });

            modelBuilder.Entity("Cafeteria_Management_System.Models.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppUserId");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<string>("EmailAddress");

                    b.Property<int?>("FoodId");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<string>("VendorName");

                    b.HasKey("VendorId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("FoodId");

                    b.HasIndex("OrderId")
                        .IsUnique()
                        .HasFilter("[OrderId] IS NOT NULL");

                    b.ToTable("Vendor");

                    b.HasData(
                        new
                        {
                            VendorId = 1,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "cuisine@gmail.com",
                            Location = "Aja",
                            VendorName = "Cuisine Kitchens"
                        },
                        new
                        {
                            VendorId = 2,
                            EmailAddress = "olasko@gmail.com",
                            Location = "Lekki",
                            VendorName = "Olasko Kitchens"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Cafeteria_Management_System.Models.AppUser", b =>
                {
                    b.HasOne("Cafeteria_Management_System.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Cafeteria_Management_System.Models.Foods", b =>
                {
                    b.HasOne("Cafeteria_Management_System.Models.Vendor", "Vendor")
                        .WithMany("Foods")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cafeteria_Management_System.Models.Order", b =>
                {
                    b.HasOne("Cafeteria_Management_System.Models.Foods", "Foods")
                        .WithMany()
                        .HasForeignKey("FoodsId");

                    b.HasOne("Cafeteria_Management_System.Models.Vendor")
                        .WithMany("Orders")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cafeteria_Management_System.Models.Vendor", b =>
                {
                    b.HasOne("Cafeteria_Management_System.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("Cafeteria_Management_System.Models.Foods", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId");

                    b.HasOne("Cafeteria_Management_System.Models.Order", "Order")
                        .WithOne("Vendor")
                        .HasForeignKey("Cafeteria_Management_System.Models.Vendor", "OrderId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Cafeteria_Management_System.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Cafeteria_Management_System.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cafeteria_Management_System.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Cafeteria_Management_System.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
