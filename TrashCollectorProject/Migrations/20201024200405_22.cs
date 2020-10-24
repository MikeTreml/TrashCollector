using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Migrations
{
    public partial class _22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedDates_Address_AddressId",
                table: "CompletedDates");

            migrationBuilder.DropIndex(
                name: "IX_CompletedDates_AddressId",
                table: "CompletedDates");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "95ea3f39-9d90-4725-a08c-155ba77d4b38", "1614f2a2-0776-4874-ab43-a69afc4d70c5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5cfc343b-5a54-4492-b6ba-f741998eed40", "5ddcf1dc-dad5-4b17-ae77-3277a9fabc84", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eea0995f-efba-4b4c-b227-61901d7a5ef4", "5792956a-adc7-4870-9dcb-939c8b145fe2", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_CompletedDates_AddressId",
                table: "CompletedDates",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedDates_Address_AddressId",
                table: "CompletedDates",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
