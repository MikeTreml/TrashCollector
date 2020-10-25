using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Migrations
{
    public partial class _24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "bfad1370-8eed-4b91-9004-b5b98a3e87d5", "5ae8884b-6a13-4d31-9b99-aa7aed9ceac4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a75afb3-ab07-40ce-876b-566b75d2a9f7", "8badd4f8-814a-450f-95e2-8d65ff65135a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "282b12df-91f7-4309-aafc-fd432374556b", "59c5005b-10fa-4884-a3d9-728ae7823e79", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "282b12df-91f7-4309-aafc-fd432374556b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a75afb3-ab07-40ce-876b-566b75d2a9f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfad1370-8eed-4b91-9004-b5b98a3e87d5");

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
    }
}
