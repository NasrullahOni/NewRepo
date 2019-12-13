using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafeteria_Management_System.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodsId",
                table: "Order",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "76f50716-519e-44ae-8a6a-815e9001533a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "25804494-c4cf-495d-a04a-0dcca0526d94");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f0bee6a3-e74e-4454-bf90-4e68b8c2450c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "47979b16-5b63-41cd-8a3b-656042ee42fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "141c4e58-7647-48a2-aac2-7e5fc48fd3d8");

            migrationBuilder.CreateIndex(
                name: "IX_Order_FoodsId",
                table: "Order",
                column: "FoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Foods_FoodsId",
                table: "Order",
                column: "FoodsId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Foods_FoodsId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_FoodsId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "FoodsId",
                table: "Order");

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
        }
    }
}
