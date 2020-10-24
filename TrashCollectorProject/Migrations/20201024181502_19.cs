using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Migrations
{
    public partial class _19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abded634-34f8-466c-b786-a8668bf6aa38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9758539-52a6-4f21-a9d6-6e6cd8c61265");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc50c66c-15b1-47f8-b739-c0a6b056aeae");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "abded634-34f8-466c-b786-a8668bf6aa38", "ad72257b-3416-4725-bd03-8c04c2af27f3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b9758539-52a6-4f21-a9d6-6e6cd8c61265", "57878000-330e-4576-8311-eaac939eb419", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc50c66c-15b1-47f8-b739-c0a6b056aeae", "21a79509-33d4-4c68-825d-3e99b67fb84e", "Employee", "EMPLOYEE" });
        }
    }
}
