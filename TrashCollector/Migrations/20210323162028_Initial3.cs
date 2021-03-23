using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bf9f542-1e0c-4f9d-a4cc-e098d6755144");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "720f7570-a52d-4a8a-8c8b-669238e74612");

            migrationBuilder.AddColumn<double>(
                name: "BalanceDue",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "86ca5974-cabd-4426-9741-c9fab38624bc", "c43b0be3-3d8d-456c-bf5a-33af4c86dbc6", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b81cb0c8-e6c4-4b68-a78e-de4b0e7c6118", "c10c05a8-6ae7-4c7f-879e-0bfbd3d352aa", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86ca5974-cabd-4426-9741-c9fab38624bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b81cb0c8-e6c4-4b68-a78e-de4b0e7c6118");

            migrationBuilder.DropColumn(
                name: "BalanceDue",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2bf9f542-1e0c-4f9d-a4cc-e098d6755144", "4982bba6-9b17-4554-b6e6-c94f7301c3eb", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "720f7570-a52d-4a8a-8c8b-669238e74612", "ff518240-a785-4880-b0ce-4449009e29fd", "Customer", "CUSTOMER" });
        }
    }
}
