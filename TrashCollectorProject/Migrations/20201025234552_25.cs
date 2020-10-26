using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Migrations
{
    public partial class _25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "de5df2be-a917-4dfd-bb8d-241f6d11c7ba", "fd46be64-9fbb-43d3-8c61-eaeda5c2447e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e452a04-bdb0-4cb1-aee1-f351c6b81627", "8ff3de25-74b0-4025-838a-1baf289541ba", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0459a01-3532-4cb4-b5a5-275c316135dc", "13fa0112-934c-4a82-b651-0cbedafee310", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e452a04-bdb0-4cb1-aee1-f351c6b81627");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0459a01-3532-4cb4-b5a5-275c316135dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de5df2be-a917-4dfd-bb8d-241f6d11c7ba");

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
    }
}
