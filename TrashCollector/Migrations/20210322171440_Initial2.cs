using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "382ddaa7-1217-4641-bb67-eade6211bd96");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1392a25-0366-4069-96be-b0bd3da12988");

            migrationBuilder.DropColumn(
                name: "BalanceDue",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "PickUpDate",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2bf9f542-1e0c-4f9d-a4cc-e098d6755144", "4982bba6-9b17-4554-b6e6-c94f7301c3eb", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "720f7570-a52d-4a8a-8c8b-669238e74612", "ff518240-a785-4880-b0ce-4449009e29fd", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bf9f542-1e0c-4f9d-a4cc-e098d6755144");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "720f7570-a52d-4a8a-8c8b-669238e74612");

            migrationBuilder.AlterColumn<int>(
                name: "PickUpDate",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BalanceDue",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "382ddaa7-1217-4641-bb67-eade6211bd96", "56a2303b-0a1b-4ff7-bc6d-ae49dd593af7", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b1392a25-0366-4069-96be-b0bd3da12988", "ab1548ba-3677-4c43-92eb-b8aaa2299b0e", "Customer", "CUSTOMER" });
        }
    }
}
