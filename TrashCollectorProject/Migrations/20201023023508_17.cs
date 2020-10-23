using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Migrations
{
    public partial class _17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09b39cc5-7bae-4e09-bb6f-d3aa1f77f2d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c54224e-87d8-4e92-807e-7f5ed734f156");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcc0de33-1816-473a-8ef1-a7f46d619c13");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2efd9d97-8d02-4422-abc3-12b849ec2875", "7b249e82-66d1-4b90-8363-06bab90902c2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0822d361-6c51-4372-9012-ce0965d94174", "cb165517-952f-4d1e-8b79-9bc323e675dd", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b445eff3-c96f-4f41-92a6-78325613fb8d", "80606761-fa4a-44f7-bed7-1d11f49a3732", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0822d361-6c51-4372-9012-ce0965d94174");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2efd9d97-8d02-4422-abc3-12b849ec2875");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b445eff3-c96f-4f41-92a6-78325613fb8d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c54224e-87d8-4e92-807e-7f5ed734f156", "60c6263c-3d29-4138-9225-03305eae80a1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dcc0de33-1816-473a-8ef1-a7f46d619c13", "3f15fbdf-92bb-425b-8ed5-f14117a3e58a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09b39cc5-7bae-4e09-bb6f-d3aa1f77f2d9", "bb8e6527-5b9f-4881-a831-aa0471c04d29", "Employee", "EMPLOYEE" });
        }
    }
}
