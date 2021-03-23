using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1bb6731-b8e4-4763-80c3-6a24889a9cd5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0f351aa-78e4-4b85-b0cc-2892db6e7971");

            migrationBuilder.AlterColumn<int>(
                name: "BalanceDue",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "341f7b65-f5b1-403c-9d01-b70dd9f86426", "8aadb7a7-adce-46cb-ac9b-5225d12f7ac7", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a3b46b4-a5ed-4288-ab89-5112d868629e", "bd29083a-2984-49c1-ab8c-e6cd177bc4e3", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a3b46b4-a5ed-4288-ab89-5112d868629e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "341f7b65-f5b1-403c-9d01-b70dd9f86426");

            migrationBuilder.AlterColumn<double>(
                name: "BalanceDue",
                table: "Customers",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0f351aa-78e4-4b85-b0cc-2892db6e7971", "3edf1468-6a00-4a30-a4b5-7bee2e298727", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1bb6731-b8e4-4763-80c3-6a24889a9cd5", "bfcf24c1-bc3a-4ad4-86f7-c72d0fd2fc17", "Customer", "CUSTOMER" });
        }
    }
}
