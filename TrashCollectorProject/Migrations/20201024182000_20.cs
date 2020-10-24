using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Migrations
{
    public partial class _20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "232ef7c3-cdd4-43fe-aff2-a57b81d0d45a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48058191-d1d1-4838-9640-e73aa8c8dca3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "762ed16b-b9f3-43a9-89b4-3b3628c82131");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "762ed16b-b9f3-43a9-89b4-3b3628c82131", "99ce97b1-4ba2-42f3-a042-c5be601d66d6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "232ef7c3-cdd4-43fe-aff2-a57b81d0d45a", "9512c0de-6525-41ba-a18b-854b19892f8d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48058191-d1d1-4838-9640-e73aa8c8dca3", "1d1eaceb-5f9f-4733-b85e-4266d9d706d7", "Employee", "EMPLOYEE" });
        }
    }
}
