using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieShareCore.Data.Migrations
{
    public partial class AddRequiredToCountryIdAndDirectorIdAllEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 11, 50, 15, 122, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 11, 50, 15, 127, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Birthdate",
                value: new DateTime(2020, 7, 8, 11, 50, 15, 127, DateTimeKind.Local).AddTicks(5181));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
