using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafeteria_Management_System.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Vendor_VendorId",
                table: "Foods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b8d02dfb-eb62-4a36-a3ae-5c20a618400b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "12279aba-bfdc-433d-93dd-355a39a83081");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a67d3e0a-1bc9-41e6-80e1-d29d336d5f30");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "f88d070b-41aa-470c-a367-2be8a0ecd6f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "4f0ad9aa-6322-4286-9d4a-b73cbfdf448b");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Vendor_VendorId",
                table: "Foods",
                column: "VendorId",
                principalTable: "Vendor",
                principalColumn: "VendorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Vendor_VendorId",
                table: "Foods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "997dedec-dbee-4c1b-b5d2-ebfda476acc7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0f3c68b5-4c93-48e8-b6af-33356bb0ced0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "088b2b72-17eb-4022-b448-96f1a55c1457");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a3e2df68-b94a-4590-b6ec-4788a9cb897b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "17805c6a-0595-464b-afdb-a9edc2a34d3c");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 10, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 10, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 10, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Vendor_VendorId",
                table: "Foods",
                column: "VendorId",
                principalTable: "Vendor",
                principalColumn: "VendorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
