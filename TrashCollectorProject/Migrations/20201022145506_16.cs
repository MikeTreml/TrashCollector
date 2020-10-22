using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Migrations
{
    public partial class _16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CompletedDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompletedDates_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OneTimeDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneTimeDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OneTimeDates_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostponeDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostponeDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostponeDates_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleDates_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CompletedDates_AddressId",
                table: "CompletedDates",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OneTimeDates_AddressId",
                table: "OneTimeDates",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PostponeDates_AddressId",
                table: "PostponeDates",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDates_AddressId",
                table: "ScheduleDates",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletedDates");

            migrationBuilder.DropTable(
                name: "OneTimeDates");

            migrationBuilder.DropTable(
                name: "PostponeDates");

            migrationBuilder.DropTable(
                name: "ScheduleDates");

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
    }
}
