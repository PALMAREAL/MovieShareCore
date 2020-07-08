using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieShareCore.Data.Migrations
{
    public partial class AddCountryIdToMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 10, 51, 24, 282, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 10, 51, 24, 286, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 10, 51, 24, 286, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CountryId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CountryId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CountryId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CountryId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CountryId",
                value: 11);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CountryId",
                table: "Movies",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Countries_CountryId",
                table: "Movies",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Countries_CountryId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CountryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Country",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Country",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Country",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Country",
                value: "JAPAN");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Country",
                value: "USA");
        }
    }
}
