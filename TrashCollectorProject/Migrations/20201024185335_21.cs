using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Migrations
{
    public partial class _21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dc65e45-68e0-4626-985b-651763a0f790");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6633ecda-d18b-4436-ae73-ff510cf3d36c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c63c2c5d-4680-4800-b7dc-1b871c2c7a2e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95ea3f39-9d90-4725-a08c-155ba77d4b38", "1614f2a2-0776-4874-ab43-a69afc4d70c5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5cfc343b-5a54-4492-b6ba-f741998eed40", "5ddcf1dc-dad5-4b17-ae77-3277a9fabc84", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eea0995f-efba-4b4c-b227-61901d7a5ef4", "5792956a-adc7-4870-9dcb-939c8b145fe2", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cfc343b-5a54-4492-b6ba-f741998eed40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95ea3f39-9d90-4725-a08c-155ba77d4b38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eea0995f-efba-4b4c-b227-61901d7a5ef4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0dc65e45-68e0-4626-985b-651763a0f790", "489ff5e0-3712-4a2b-8549-d485d71e7ec7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6633ecda-d18b-4436-ae73-ff510cf3d36c", "7190f38f-f80c-4324-a1ba-7052785a3d2b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c63c2c5d-4680-4800-b7dc-1b871c2c7a2e", "3a7010fe-854d-4b25-a09f-e5703ba2cac8", "Employee", "EMPLOYEE" });
        }
    }
}
