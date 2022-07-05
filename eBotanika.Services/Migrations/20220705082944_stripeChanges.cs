using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBotanika.Services.Migrations
{
    public partial class stripeChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Placanje",
                keyColumn: "PlacanjeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Placanje",
                keyColumn: "PlacanjeID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "BrojKartice",
                table: "Placanje");

            migrationBuilder.DropColumn(
                name: "ExpMonth",
                table: "Placanje");

            migrationBuilder.DropColumn(
                name: "ExpYear",
                table: "Placanje");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Placanje");

            migrationBuilder.AddColumn<string>(
                name: "BrojTransakcije",
                table: "Placanje",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Placanje",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojTransakcije",
                table: "Placanje");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Placanje");

            migrationBuilder.AddColumn<int>(
                name: "BrojKartice",
                table: "Placanje",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpMonth",
                table: "Placanje",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpYear",
                table: "Placanje",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecurityCode",
                table: "Placanje",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.InsertData(
                table: "Placanje",
                columns: new[] { "PlacanjeID", "BrojKartice", "ExpMonth", "ExpYear", "Iznos", "KorisnikID", "SecurityCode" },
                values: new object[,]
                {
                    { 1, 123445677, 2, 23, 23.0, 1, 123 },
                    { 2, 987654678, 7, 25, 89.0, 2, 134 }
                });
        }
    }
}
