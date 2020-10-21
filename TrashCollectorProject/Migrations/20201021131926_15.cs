using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Migrations
{
    public partial class _15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91fdf2f0-5806-48b4-8141-b9442aba9516");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcaeec36-68cb-48d8-8415-da24548a00c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eac8cca7-97e0-4e34-8c5f-4ffd8f2215eb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e45f614-788f-44e6-a83a-21bc649eb072", "9d6a874c-6e5e-42e1-b292-a8efa9ff08db", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7121deda-e441-4c87-9ff3-234bde3bd1cf", "1aa4392d-94fd-497a-b077-1fe9edd00ca7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5609883b-ae84-4e94-a7e4-92e35739d90d", "01fffb8b-8e8a-4104-b86a-5978fd29dd10", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e45f614-788f-44e6-a83a-21bc649eb072");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5609883b-ae84-4e94-a7e4-92e35739d90d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7121deda-e441-4c87-9ff3-234bde3bd1cf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eac8cca7-97e0-4e34-8c5f-4ffd8f2215eb", "0813f33d-8068-448a-bd09-a8d21556480f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bcaeec36-68cb-48d8-8415-da24548a00c3", "ba3f14d2-66c4-4f6f-9a8d-0d9aa700ef3c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91fdf2f0-5806-48b4-8141-b9442aba9516", "57aac434-f440-4dbf-b351-c8785e28e4d1", "Employee", "EMPLOYEE" });
        }
    }
}
