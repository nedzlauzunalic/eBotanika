using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBotanika.Services.Migrations
{
    public partial class inicijalno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradID);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    KategorijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.KategorijaID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "Svrha",
                columns: table => new
                {
                    SvrhaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Svrha", x => x.SvrhaID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "Uposlenik",
                columns: table => new
                {
                    UposlenikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposlenik", x => x.UposlenikID);
                });

            migrationBuilder.CreateTable(
                name: "Biljke",
                columns: table => new
                {
                    BiljkeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategorijaID = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Slika = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biljke", x => x.BiljkeID);
                    table.ForeignKey(
                        name: "FK_Biljke_Kategorija",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorija",
                        principalColumn: "KategorijaID");
                });

            migrationBuilder.CreateTable(
                name: "Placanje",
                columns: table => new
                {
                    PlacanjeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    BrojKartice = table.Column<int>(type: "int", nullable: false),
                    SecurityCode = table.Column<int>(type: "int", nullable: false),
                    ExpYear = table.Column<int>(type: "int", nullable: false),
                    ExpMonth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placanje", x => x.PlacanjeID);
                    table.ForeignKey(
                        name: "FK_Placanje_Korisnik",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID");
                });

            migrationBuilder.CreateTable(
                name: "UposlenikUloge",
                columns: table => new
                {
                    UposlenikUlogeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UposlenikID = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_UposlenikUloge_Uposlenik",
                        column: x => x.UposlenikID,
                        principalTable: "Uposlenik",
                        principalColumn: "UposlenikID");
                });

            migrationBuilder.CreateTable(
                name: "Ocjena",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OcjenaUsluge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    BiljkeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjena", x => x.OcjenaID);
                    table.ForeignKey(
                        name: "FK_Ocjena_Biljke",
                        column: x => x.BiljkeID,
                        principalTable: "Biljke",
                        principalColumn: "BiljkeID");
                    table.ForeignKey(
                        name: "FK_Ocjena_Korisnik",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID");
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumRezervacije = table.Column<DateTime>(type: "datetime", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    GradID = table.Column<int>(type: "int", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    SvrhaID = table.Column<int>(type: "int", nullable: false),
                    AdresaDostave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BiljkeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.RezervacijaID);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Biljke_BiljkeID",
                        column: x => x.BiljkeID,
                        principalTable: "Biljke",
                        principalColumn: "BiljkeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Grad",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID");
                    table.ForeignKey(
                        name: "FK_Rezervacije_Korisnik",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID");
                    table.ForeignKey(
                        name: "FK_Rezervacije_Svrha",
                        column: x => x.SvrhaID,
                        principalTable: "Svrha",
                        principalColumn: "SvrhaID");
                });

            migrationBuilder.CreateTable(
                name: "Dostava",
                columns: table => new
                {
                    DostavaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumSlanja = table.Column<DateTime>(type: "datetime", nullable: true),
                    DatumPreuzimanja = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrenutnaLokacija = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RezervacijaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostava", x => x.DostavaID);
                    table.ForeignKey(
                        name: "FK_Dostava_Rezervacije",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaID");
                });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "GradID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Sarajevo" },
                    { 2, "Tuzla" },
                    { 3, "Zenica" }
                });

            migrationBuilder.InsertData(
                table: "Kategorija",
                columns: new[] { "KategorijaID", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 1, "Jednogodišnja", "Jednogodišnjim biljkama se cijeli životni ciklus odvija u toku jednog vegetacijskog perioda." },
                    { 2, "Višegodišnja", "Višegodišnja biljka je biljka koja živi duže od dvije godine." },
                    { 3, "Listopadne", "Listopadne biljke su sve vrste biljaka koje gube svoje listove pred nastupajući nepovoljni period." },
                    { 4, "Zimzelene", "Zimzelene biljke predstavljaju dominantni dio rasprostranjen po cijeloj Zemlji." },
                    { 5, "Crnogorične", "Crnogoričnim šumama nazivamo šume koje ne odbacuje lišće, nego ga zadržava cijele godine." }
                });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "KorisnikID", "DatumRodjenja", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Telefon" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 11, 14, 54, 57, 697, DateTimeKind.Local).AddTicks(3456), "korisnik@live.com", "Mobile", "mobile", "bUBHhasx3aUpr7cmjozMzIeL35c=", "zthomrUyhZjeapvj5KYL+A==", "Mobile", "+38762345678" },
                    { 2, new DateTime(2022, 6, 11, 14, 54, 57, 697, DateTimeKind.Local).AddTicks(3531), "adnan@live.com", "Adnan", "adnan", "bUBHhasx3aUpr7cmjozMzIeL35c=", "zthomrUyhZjeapvj5KYL+A==", "Pobric", "+38762345676" }
                });

            migrationBuilder.InsertData(
                table: "Svrha",
                columns: new[] { "SvrhaID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Kupovina" },
                    { 2, "Uredjivanje vrtova/parkova" },
                    { 3, "Aranzman" }
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "UlogaID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Radnik" }
                });

            migrationBuilder.InsertData(
                table: "Uposlenik",
                columns: new[] { "UposlenikID", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Telefon" },
                values: new object[,]
                {
                    { 1, "admin@live.com", "Admin", "desktop", "bUBHhasx3aUpr7cmjozMzIeL35c=", "zthomrUyhZjeapvj5KYL+A==", "Admin", "+38762123456" },
                    { 2, "radnik1@live.com", "Radnik1", "desktop2", "ctdN66Ftv+YJP9LAK6i3dKDqchg=", "NSqADQ/R7xKWHlTVz2BMwg==", "Radnik1", "+38762345678" }
                });

            migrationBuilder.InsertData(
                table: "Biljke",
                columns: new[] { "BiljkeID", "Cijena", "KategorijaID", "Naziv", "Opis", "Slika" },
                values: new object[,]
                {
                    { 1, 1m, 1, "Petunija", "Petunija pripada porodici pomoćnica,porijeklom iz Južne Amerike.", "images/1.jpg" },
                    { 2, 3m, 2, "Lavanda ", "Lavanda cvati u proljeće i u jesen ukoliko se dobro podreže nakon prve cvatnje.", "images/2.jpg" },
                    { 3, 65m, 3, "Kesten", "Pitomi kesten (Castanea sativa) je listopadno stablo iz porodice bukvi.", "images/3.jpg" },
                    { 4, 50m, 4, "Patuljasta kleka", "Patuljak smreka je jedna od mnogo varijanti ove zimzelene biljke koja obično raste kao grm.", "images/4.jpg" },
                    { 5, 45m, 5, "Planinski bor", "Planinski bor, klekovina ili bor krivulj je crnogorična vrsta drveća iz porodice Pinaceae.", "images/5.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Placanje",
                columns: new[] { "PlacanjeID", "BrojKartice", "ExpMonth", "ExpYear", "KorisnikID", "SecurityCode" },
                values: new object[,]
                {
                    { 1, 123445677, 2, 23, 1, 123 },
                    { 2, 987654678, 7, 25, 2, 134 }
                });

            migrationBuilder.InsertData(
                table: "UposlenikUloge",
                columns: new[] { "UposlenikUlogeID", "DatumIzmjene", "UlogaID", "UposlenikID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 13, 20, 10, 26, 966, DateTimeKind.Local), 1, 1 },
                    { 2, new DateTime(2020, 6, 13, 20, 10, 26, 966, DateTimeKind.Local), 2, 2 }
                });

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
                table: "Rezervacije",
                columns: new[] { "RezervacijaID", "AdresaDostave", "BiljkeID", "DatumRezervacije", "GradID", "Kolicina", "KorisnikID", "Napomena", "SvrhaID" },
                values: new object[,]
                {
                    { 1, "Ćamila Sijarića", 1, new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1, "", 1 },
                    { 2, "Azize Šaćirbegović", 2, new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2, "Dostava na adresu", 2 },
                    { 3, "Nedima Filipovića", 3, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 1, "Placanje pri preuzimanju", 1 },
                    { 4, "Hasana Brkića", 4, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, 2, "Placanje pri preuzimanju", 3 }
                });

            migrationBuilder.InsertData(
                table: "Dostava",
                columns: new[] { "DostavaID", "DatumPreuzimanja", "DatumSlanja", "Napomena", "RezervacijaID", "TrenutnaLokacija" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dostava kasni 5min", 1, "Sremska" },
                    { 2, new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, "Skadarska" },
                    { 3, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "Ranka Šipke" },
                    { 4, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, "Oraščka" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biljke_KategorijaID",
                table: "Biljke",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Dostava_RezervacijaID",
                table: "Dostava",
                column: "RezervacijaID");

            migrationBuilder.CreateIndex(
                name: "Korisnik_Email",
                table: "Korisnik",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_BiljkeID",
                table: "Ocjena",
                column: "BiljkeID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_KorisnikID",
                table: "Ocjena",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Placanje_KorisnikID",
                table: "Placanje",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_BiljkeID",
                table: "Rezervacije",
                column: "BiljkeID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_GradID",
                table: "Rezervacije",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_KorisnikID",
                table: "Rezervacije",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_SvrhaID",
                table: "Rezervacije",
                column: "SvrhaID");

            migrationBuilder.CreateIndex(
                name: "Korisnik_Email",
                table: "Uposlenik",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UposlenikUloge_UlogaID",
                table: "UposlenikUloge",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_UposlenikUloge_UposlenikID",
                table: "UposlenikUloge",
                column: "UposlenikID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dostava");

            migrationBuilder.DropTable(
                name: "Ocjena");

            migrationBuilder.DropTable(
                name: "Placanje");

            migrationBuilder.DropTable(
                name: "UposlenikUloge");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Uposlenik");

            migrationBuilder.DropTable(
                name: "Biljke");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Svrha");

            migrationBuilder.DropTable(
                name: "Kategorija");
        }
    }
}
