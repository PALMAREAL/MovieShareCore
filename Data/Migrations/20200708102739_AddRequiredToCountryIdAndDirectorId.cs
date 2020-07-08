using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieShareCore.Data.Migrations
{
    public partial class AddRequiredToCountryIdAndDirectorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 11, 27, 39, 332, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 11, 27, 39, 335, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 11, 27, 39, 336, DateTimeKind.Local).AddTicks(829));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 11, 1, 56, 330, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 11, 1, 56, 334, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 11, 1, 56, 334, DateTimeKind.Local).AddTicks(2082));
        }
    }
}
