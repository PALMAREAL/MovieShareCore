using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieShareCore.Data.Migrations
{
    public partial class AddCountryIdToDirector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Directors");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Directors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 10, 45, 5, 177, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 10, 45, 5, 181, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 10, 45, 5, 181, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CountryId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CountryId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CountryId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CountryId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CountryId",
                value: 20);

            migrationBuilder.CreateIndex(
                name: "IX_Directors_CountryId",
                table: "Directors",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Countries_CountryId",
                table: "Directors",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Countries_CountryId",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Directors_CountryId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Directors");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 10, 40, 35, 68, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 10, 40, 35, 71, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 10, 40, 35, 71, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Country",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Country",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Country",
                value: "UK");

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Country",
                value: "CUBA");

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Country",
                value: "Cuba");
        }
    }
}
