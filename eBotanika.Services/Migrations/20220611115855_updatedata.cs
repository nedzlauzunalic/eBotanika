using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBotanika.Services.Migrations
{
    public partial class updatedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 6, 11, 13, 58, 54, 692, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 6, 11, 13, 58, 54, 692, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.InsertData(
                table: "Ocjena",
                columns: new[] { "OcjenaID", "BiljkeID", "KorisnikID", "OcjenaUsluge" },
                values: new object[,]
                {
                    { 1, 1, 1, 4m },
                    { 2, 2, 1, 5m },
                    { 3, 3, 2, 5m },
                    { 4, 2, 2, 4m }
                });

            migrationBuilder.InsertData(
                table: "Placanje",
                columns: new[] { "PlacanjeID", "BrojKartice", "ExpMonth", "ExpYear", "KorisnikID", "SecurityCode" },
                values: new object[,]
                {
                    { 1, 123445677, 2, 23, 1, 123 },
                    { 2, 987654678, 7, 25, 2, 134 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ocjena",
                keyColumn: "OcjenaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ocjena",
                keyColumn: "OcjenaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ocjena",
                keyColumn: "OcjenaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ocjena",
                keyColumn: "OcjenaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Placanje",
                keyColumn: "PlacanjeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Placanje",
                keyColumn: "PlacanjeID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 6, 10, 17, 51, 49, 480, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 6, 10, 17, 51, 49, 480, DateTimeKind.Local).AddTicks(8967));
        }
    }
}
