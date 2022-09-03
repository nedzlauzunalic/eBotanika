using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBotanika.Services.Migrations
{
    public partial class ocjenaRezervacije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OcjenaID",
                table: "Rezervacije",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Ocjena",
                keyColumn: "OcjenaID",
                keyValue: 2,
                column: "BiljkeID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ocjena",
                keyColumn: "OcjenaID",
                keyValue: 3,
                column: "BiljkeID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 1,
                column: "OcjenaID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 2,
                column: "OcjenaID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 3,
                column: "OcjenaID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 4,
                column: "OcjenaID",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_OcjenaID",
                table: "Rezervacije",
                column: "OcjenaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacije_Ocjena_OcjenaID",
                table: "Rezervacije",
                column: "OcjenaID",
                principalTable: "Ocjena",
                principalColumn: "OcjenaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacije_Ocjena_OcjenaID",
                table: "Rezervacije");

            migrationBuilder.DropIndex(
                name: "IX_Rezervacije_OcjenaID",
                table: "Rezervacije");

            migrationBuilder.DropColumn(
                name: "OcjenaID",
                table: "Rezervacije");

            migrationBuilder.UpdateData(
                table: "Ocjena",
                keyColumn: "OcjenaID",
                keyValue: 2,
                column: "BiljkeID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ocjena",
                keyColumn: "OcjenaID",
                keyValue: 3,
                column: "BiljkeID",
                value: 3);
        }
    }
}
