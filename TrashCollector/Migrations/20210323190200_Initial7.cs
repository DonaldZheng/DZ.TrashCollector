using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a3b46b4-a5ed-4288-ab89-5112d868629e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "341f7b65-f5b1-403c-9d01-b70dd9f86426");

            migrationBuilder.DropColumn(
                name: "PickUpDate",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPickUp",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PickUpDay",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d227087d-3751-4bbc-b51f-8a9ed161ff66", "78a6be2d-87fb-439a-a4ce-16584e892a97", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b1549f8d-e6b7-4c9e-986b-976e0b62ce21", "df94acd2-5378-4ee0-8576-6cb2c8ee9358", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1549f8d-e6b7-4c9e-986b-976e0b62ce21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d227087d-3751-4bbc-b51f-8a9ed161ff66");

            migrationBuilder.DropColumn(
                name: "ConfirmPickUp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PickUpDay",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "PickUpDate",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "341f7b65-f5b1-403c-9d01-b70dd9f86426", "8aadb7a7-adce-46cb-ac9b-5225d12f7ac7", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a3b46b4-a5ed-4288-ab89-5112d868629e", "bd29083a-2984-49c1-ab8c-e6cd177bc4e3", "Customer", "CUSTOMER" });
        }
    }
}
