using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafeteria_Management_System.Migrations
{
    public partial class date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Order",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Order",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "951cf85d-6f26-486a-b4e5-9a3150a12edc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "89d158d9-b181-4aea-a697-ecdb55e7e39a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "52c627cd-7a70-4d77-ae09-ed510563a110");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "64b637b5-2feb-451c-9bd2-72a1945f133a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "b994aea3-37d8-49aa-b47f-10b8dd0fe418");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Date",
                value: "10/26/2019 1:46:33 PM Saturday");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Date",
                value: "10/26/2019 1:46:33 PM Saturday");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "Date",
                value: "10/26/2019 1:46:33 PM Saturday");
        }
    }
}
