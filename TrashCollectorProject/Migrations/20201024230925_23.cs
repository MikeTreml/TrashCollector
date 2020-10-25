using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Migrations
{
    public partial class _23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6797f47b-95d4-47eb-ab49-97e5ef894c45");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67ec2fef-05e0-49ee-92c3-545b376449a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee13294d-15b7-424b-8a01-d1c6d6f5b11f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6e0ba59-d4ad-4ddc-94ff-d1d0fca0c360", "8b1b1905-db73-4d02-b5c2-b143ecf05e37", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e274825b-f093-4684-8e46-ae8af42afd21", "e08b0348-7b48-4d15-b065-76125d094aa4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2dcf0f60-2d93-49a0-8036-e7fe94643b06", "9fdb9a60-65da-4e05-afe9-d8a98e1af8d6", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dcf0f60-2d93-49a0-8036-e7fe94643b06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e274825b-f093-4684-8e46-ae8af42afd21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6e0ba59-d4ad-4ddc-94ff-d1d0fca0c360");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6797f47b-95d4-47eb-ab49-97e5ef894c45", "208f3e32-25a7-4ccd-8da1-f5dfaf93e2af", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee13294d-15b7-424b-8a01-d1c6d6f5b11f", "c69217da-4bdb-463b-87f8-64eb2343798a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67ec2fef-05e0-49ee-92c3-545b376449a1", "32075f64-8b97-4d56-a48b-773ecf718f89", "Employee", "EMPLOYEE" });
        }
    }
}
