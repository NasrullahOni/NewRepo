using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafeteria_Management_System.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VendorName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false, defaultValueSql: "GetUtcDate()"),
                    OrderId = table.Column<int>(nullable: true),
                    FoodId = table.Column<int>(nullable: true),
                    AppUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Food = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    VendorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Food = table.Column<string>(nullable: true),
                    OrderedByMe = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Accepted = table.Column<string>(nullable: true),
                    StaffName = table.Column<string>(nullable: true),
                    VendorName = table.Column<string>(nullable: true),
                    StaffId = table.Column<string>(nullable: true),
                    StaffDepartment = table.Column<string>(nullable: true),
                    VendorId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    StaffId = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Department", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrderId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "76e60549-9072-4e87-80e0-03f3aeaff4c4", "Social", "afeez@yahoo.com", false, false, null, null, null, null, null, null, false, null, "INI/123", false, "Afeez" },
                    { 2, 0, "20098f12-b5af-42eb-a87a-407d987ad399", "Social", "kayode@yahoo.com", false, false, null, null, null, null, null, null, false, null, "INI/246", false, "Olamide" },
                    { 3, 0, "52a7cebf-55c9-4b2c-88f0-ddb97d464b1b", "Social", "kayode@yahoo.com", false, false, null, null, null, null, null, null, false, null, "INI/247", false, "Kayode" },
                    { 4, 0, "08dde533-002c-4bd0-ac80-53fdc9319c9d", "Software", "kayode@yahoo.com", false, false, null, null, null, null, null, null, false, null, "INI/248", false, "Dele" },
                    { 5, 0, "ac9ff608-21cd-4616-ab4c-e13a4a7dd1e2", "CyberAcademy", "DObam@yahoo.com", false, false, null, null, null, null, null, null, false, null, "INI/249", false, "David Obafemi Olamide" }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorId", "AppUserId", "EmailAddress", "FoodId", "Location", "Name", "OrderId", "VendorName" },
                values: new object[] { 1, null, "cuisine@gmail.com", null, "Aja", null, null, "Cuisine Kitchens" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorId", "AppUserId", "EmailAddress", "FoodId", "Location", "Name", "OrderId", "VendorName" },
                values: new object[] { 2, null, "olasko@gmail.com", null, "Lekki", null, null, "Olasko Kitchens" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Food", "Type", "VendorId" },
                values: new object[,]
                {
                    { 1, "Semo,Amala,Eba,Poundo-Yam,Rice,Rice&Beans, Jollof-Rice, Jollof-Rice & Beans", "Base-Food", 1 },
                    { 2, "EFo, Ewedu, Draw-Soup,Red-Soup", "Soup", 1 },
                    { 3, "Goat-Meat-2, Cow-Meat-2, GoatMeat & Pomo, Cow-Meat & Pomo, Fish-2, Fish & GoatMeat", "Meat", 1 },
                    { 4, "Salad, Cucumber, Carrot, Plantain", "Food-Accessories", 1 },
                    { 5, "Eba,Amala,Eba,FriedRice,Rice,Rice&Beans, Jollof-Rice, Jollof-Rice & Beans", "Base-Food", 2 },
                    { 6, "EFo, Ewedu, Draw-Soup,Red-Soup,Edikaikan", "Soup", 2 },
                    { 7, "Goat-Meat-2, Cow-Meat-2, GoatMeat & Pomo, Cow-Meat & Pomo, Fish-2, Fish & GoatMeat, Chicken", "Meat", 2 },
                    { 8, "Salad, Cucumber, Carrot, Plantain", "Food-Accessories", 2 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "Accepted", "Date", "Food", "OrderedByMe", "StaffDepartment", "StaffId", "StaffName", "UserId", "VendorId", "VendorName" },
                values: new object[,]
                {
                    { 1, "Yes", "10/23/2019 7:59:04 PM Wednesday", "Rice, Beans, Plantain", "Yes", "Social", "INI/123", "Afeez", 1, 1, "Cuisine Kitchens" },
                    { 2, "Yes", "10/23/2019 7:59:04 PM Wednesday", "Rice, EFo, Plantain", "Yes", "Social", "INI/246", "Olamide", 2, 1, "Cuisine Kitchens" },
                    { 3, "Yes", "10/23/2019 7:59:04 PM Wednesday", "Rice, EFo, Plantain", "Yes", "Social", "INI/246", "Olamide", 2, 1, "Cuisine Kitchens" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_OrderId",
                table: "AspNetUsers",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_VendorId",
                table: "Foods",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_VendorId",
                table: "Order",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_AppUserId",
                table: "Vendor",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_FoodId",
                table: "Vendor",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_OrderId",
                table: "Vendor",
                column: "OrderId",
                unique: true,
                filter: "[OrderId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_AspNetUsers_AppUserId",
                table: "Vendor",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_Order_OrderId",
                table: "Vendor",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_Foods_FoodId",
                table: "Vendor",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_AspNetUsers_AppUserId",
                table: "Vendor");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_Order_OrderId",
                table: "Vendor");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Vendor_VendorId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
