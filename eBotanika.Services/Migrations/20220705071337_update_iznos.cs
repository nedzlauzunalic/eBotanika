using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBotanika.Services.Migrations
{
    public partial class update_iznos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 1,
                column: "Cijena",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 2,
                column: "Cijena",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 3,
                column: "Cijena",
                value: 270m);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 4,
                column: "Cijena",
                value: 180m);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 5,
                column: "Cijena",
                value: 138m);

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 7, 5, 9, 13, 36, 691, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 7, 5, 9, 13, 36, 691, DateTimeKind.Local).AddTicks(1539));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 1,
                column: "Cijena",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 2,
                column: "Cijena",
                value: 3m);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 3,
                column: "Cijena",
                value: 65m);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 4,
                column: "Cijena",
                value: 50m);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 5,
                column: "Cijena",
                value: 45m);

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 7, 4, 11, 4, 9, 210, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 7, 4, 11, 4, 9, 210, DateTimeKind.Local).AddTicks(813));
        }
    }
}
