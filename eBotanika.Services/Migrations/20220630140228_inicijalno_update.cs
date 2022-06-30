using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBotanika.Services.Migrations
{
    public partial class inicijalno_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 1,
                column: "Slika",
                value: "1.jpg");

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 2,
                column: "Slika",
                value: "2.jpg");

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 3,
                column: "Slika",
                value: "3.jpg");

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 4,
                column: "Slika",
                value: "4.jpg");

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 5,
                column: "Slika",
                value: "5.jpg");

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 6, 30, 16, 2, 27, 691, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 6, 30, 16, 2, 27, 691, DateTimeKind.Local).AddTicks(8370));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 1,
                column: "Slika",
                value: "images/1.jpg");

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 2,
                column: "Slika",
                value: "images/2.jpg");

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 3,
                column: "Slika",
                value: "images/3.jpg");

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 4,
                column: "Slika",
                value: "images/4.jpg");

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 5,
                column: "Slika",
                value: "images/5.jpg");

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 6, 11, 14, 54, 57, 697, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 6, 11, 14, 54, 57, 697, DateTimeKind.Local).AddTicks(3531));
        }
    }
}
