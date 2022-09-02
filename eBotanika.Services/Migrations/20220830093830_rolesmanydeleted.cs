using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBotanika.Services.Migrations
{
    public partial class rolesmanydeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UposlenikUloge");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UposlenikUloge",
                columns: table => new
                {
                    UposlenikUlogeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlogaID = table.Column<int>(type: "int", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UposlenikUloge", x => x.UposlenikUlogeID);
                    table.ForeignKey(
                        name: "FK_UposlenikUloge_Uloga",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaID");
                });

            migrationBuilder.InsertData(
                table: "UposlenikUloge",
                columns: new[] { "UposlenikUlogeID", "DatumIzmjene", "UlogaID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 13, 20, 10, 26, 966, DateTimeKind.Local), 1 },
                    { 2, new DateTime(2020, 6, 13, 20, 10, 26, 966, DateTimeKind.Local), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UposlenikUloge_UlogaID",
                table: "UposlenikUloge",
                column: "UlogaID");
        }
    }
}
