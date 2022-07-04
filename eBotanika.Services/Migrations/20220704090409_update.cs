using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBotanika.Services.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Iznos",
                table: "Placanje",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "KorisnikID",
                table: "Dostava",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Dostava",
                keyColumn: "DostavaID",
                keyValue: 1,
                column: "KorisnikID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dostava",
                keyColumn: "DostavaID",
                keyValue: 2,
                column: "KorisnikID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Dostava",
                keyColumn: "DostavaID",
                keyValue: 3,
                column: "KorisnikID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dostava",
                keyColumn: "DostavaID",
                keyValue: 4,
                column: "KorisnikID",
                value: 2);

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

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "PlacanjeID",
                keyValue: 1,
                column: "Iznos",
                value: 23.0);

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "PlacanjeID",
                keyValue: 2,
                column: "Iznos",
                value: 89.0);

            migrationBuilder.CreateIndex(
                name: "IX_Dostava_KorisnikID",
                table: "Dostava",
                column: "KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dostava_Korisnik_KorisnikID",
                table: "Dostava",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dostava_Korisnik_KorisnikID",
                table: "Dostava");

            migrationBuilder.DropIndex(
                name: "IX_Dostava_KorisnikID",
                table: "Dostava");

            migrationBuilder.DropColumn(
                name: "Iznos",
                table: "Placanje");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Dostava");

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
    }
}
