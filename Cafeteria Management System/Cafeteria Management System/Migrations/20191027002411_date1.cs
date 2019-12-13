using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafeteria_Management_System.Migrations
{
    public partial class date1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5c9eb7c1-b441-4b46-a7b9-4b9add5ce935");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c979c2fd-ae26-4c51-bd28-4baa65d02820");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "9aa72dc7-61d8-4339-b42f-4a1dffdd3b22");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "f71b18cd-b537-4da9-857d-83ae2af2e589");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "702b179c-81e8-4922-a8ef-a5bee4505f66");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "809e3f2d-3545-44ca-b3c8-d354dc832911");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8ef484db-9131-43ea-960e-491984d0e9f8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6ff18104-b114-4e8d-b359-445b2a6c3b8c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "99d5b92a-fd0c-4009-bbe2-3b2f83b7c8b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "7b9ec81c-e2b7-4a47-931d-441203d98392");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 10, 27, 1, 19, 47, 690, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 10, 27, 1, 19, 47, 692, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 10, 27, 1, 19, 47, 692, DateTimeKind.Local).AddTicks(9744));
        }
    }
}
