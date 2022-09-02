using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBotanika.Services.Migrations
{
    public partial class biljkeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UposlenikID",
                table: "Biljke",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 1,
                column: "UposlenikID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 2,
                column: "UposlenikID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 3,
                column: "UposlenikID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 4,
                column: "UposlenikID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Biljke",
                keyColumn: "BiljkeID",
                keyValue: 5,
                column: "UposlenikID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 8, 28, 16, 35, 57, 331, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 8, 28, 16, 35, 57, 331, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.CreateIndex(
                name: "IX_Biljke_UposlenikID",
                table: "Biljke",
                column: "UposlenikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Biljke_Uposlenik",
                table: "Biljke",
                column: "UposlenikID",
                principalTable: "Uposlenik",
                principalColumn: "UposlenikID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biljke_Uposlenik",
                table: "Biljke");

            migrationBuilder.DropIndex(
                name: "IX_Biljke_UposlenikID",
                table: "Biljke");

            migrationBuilder.DropColumn(
                name: "UposlenikID",
                table: "Biljke");

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 7, 5, 10, 29, 43, 515, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 7, 5, 10, 29, 43, 515, DateTimeKind.Local).AddTicks(2037));
        }
    }
}
