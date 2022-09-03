using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBotanika.Services.Migrations
{
    public partial class ocjenausluge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacije_Biljke_BiljkeID",
                table: "Rezervacije");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacije_Grad",
                table: "Rezervacije");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacije_Ocjena_OcjenaID",
                table: "Rezervacije");

            migrationBuilder.RenameColumn(
                name: "GradID",
                table: "Rezervacije",
                newName: "OcjenaID1");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacije_GradID",
                table: "Rezervacije",
                newName: "IX_Rezervacije_OcjenaID1");

            migrationBuilder.AddColumn<decimal>(
                name: "OcjenaUsluge",
                table: "Rezervacije",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 1,
                column: "OcjenaUsluge",
                value: 4m);

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 2,
                columns: new[] { "OcjenaID", "OcjenaID1", "OcjenaUsluge" },
                values: new object[] { 2, 4, 4m });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 3,
                columns: new[] { "OcjenaID", "OcjenaID1", "OcjenaUsluge" },
                values: new object[] { 1, 2, 5m });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 4,
                column: "OcjenaUsluge",
                value: 5m);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacije_Biljke",
                table: "Rezervacije",
                column: "BiljkeID",
                principalTable: "Biljke",
                principalColumn: "BiljkeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacije_Grad",
                table: "Rezervacije",
                column: "OcjenaID",
                principalTable: "Gradovi",
                principalColumn: "GradID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacije_Ocjena",
                table: "Rezervacije",
                column: "OcjenaID1",
                principalTable: "Ocjena",
                principalColumn: "OcjenaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacije_Biljke",
                table: "Rezervacije");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacije_Grad",
                table: "Rezervacije");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacije_Ocjena",
                table: "Rezervacije");

            migrationBuilder.DropColumn(
                name: "OcjenaUsluge",
                table: "Rezervacije");

            migrationBuilder.RenameColumn(
                name: "OcjenaID1",
                table: "Rezervacije",
                newName: "GradID");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacije_OcjenaID1",
                table: "Rezervacije",
                newName: "IX_Rezervacije_GradID");

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 2,
                columns: new[] { "GradID", "OcjenaID" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 3,
                columns: new[] { "GradID", "OcjenaID" },
                values: new object[] { 1, 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacije_Biljke_BiljkeID",
                table: "Rezervacije",
                column: "BiljkeID",
                principalTable: "Biljke",
                principalColumn: "BiljkeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacije_Grad",
                table: "Rezervacije",
                column: "GradID",
                principalTable: "Gradovi",
                principalColumn: "GradID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacije_Ocjena_OcjenaID",
                table: "Rezervacije",
                column: "OcjenaID",
                principalTable: "Ocjena",
                principalColumn: "OcjenaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
