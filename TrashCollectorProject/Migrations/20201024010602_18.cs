using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Migrations
{
    public partial class _18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PickUpDay",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "PickUpDay",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
