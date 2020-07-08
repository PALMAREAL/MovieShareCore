using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieShareCore.Data.Migrations
{
    public partial class AddCountryIdToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CountryId" },
                values: new object[] { new DateTime(2020, 7, 8, 10, 40, 35, 68, DateTimeKind.Local).AddTicks(71), 53 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Birthdate", "CountryId" },
                values: new object[] { new DateTime(2020, 7, 8, 10, 40, 35, 71, DateTimeKind.Local).AddTicks(4515), 55 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Birthdate", "CountryId" },
                values: new object[] { new DateTime(2020, 7, 8, 10, 40, 35, 71, DateTimeKind.Local).AddTicks(4598), 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountryId",
                table: "Customers",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Countries_CountryId",
                table: "Customers",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Countries_CountryId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CountryId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "Country" },
                values: new object[] { new DateTime(2020, 7, 4, 19, 29, 6, 560, DateTimeKind.Local).AddTicks(8942), "Cuba" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Birthdate", "Country" },
                values: new object[] { new DateTime(2020, 7, 4, 19, 29, 6, 564, DateTimeKind.Local).AddTicks(2994), "Cuba" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Birthdate", "Country" },
                values: new object[] { new DateTime(2020, 7, 4, 19, 29, 6, 564, DateTimeKind.Local).AddTicks(3079), "Cuba" });
        }
    }
}
