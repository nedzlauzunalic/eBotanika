using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBotanika.Services.Migrations
{
    public partial class rolesupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UlogaID",
                table: "Uposlenik",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Uposlenik",
                keyColumn: "UposlenikID",
                keyValue: 1,
                column: "UlogaID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Uposlenik",
                keyColumn: "UposlenikID",
                keyValue: 2,
                column: "UlogaID",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_UlogaID",
                table: "Uposlenik",
                column: "UlogaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Uposlenik_Uloge",
                table: "Uposlenik",
                column: "UlogaID",
                principalTable: "Uloge",
                principalColumn: "UlogaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uposlenik_Uloge",
                table: "Uposlenik");

            migrationBuilder.DropIndex(
                name: "IX_Uposlenik_UlogaID",
                table: "Uposlenik");

            migrationBuilder.DropColumn(
                name: "UlogaID",
                table: "Uposlenik");
        }
    }
}
