using Microsoft.EntityFrameworkCore;

namespace eBotanika.Services.Database
{
    public partial class eBotanikaContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            #region ULOGE
            modelBuilder.Entity<Uloge>().HasData(new Uloge()
            { 
               UlogaID=1,
               Naziv= "Administrator"
            });
            modelBuilder.Entity<Uloge>().HasData(new Uloge()
            {
                UlogaID = 2,
                Naziv = "Radnik"
            });
            #endregion

            #region UPOSLENICI
            modelBuilder.Entity<Uposlenik>().HasData(new Uposlenik()
            {
                UposlenikID = 1,
                Ime = "Admin",
                Prezime = "Admin",
                Email = "admin@live.com",
                Telefon = "+38762123456",
                KorisnickoIme = "desktop",
                LozinkaHash = "bUBHhasx3aUpr7cmjozMzIeL35c=",
                LozinkaSalt = "zthomrUyhZjeapvj5KYL+A=="
            });
            modelBuilder.Entity<Uposlenik>().HasData(new Uposlenik()
            {
                UposlenikID = 2,
                Ime = "Radnik1",
                Prezime = "Radnik1",
                Email = "radnik1@live.com",
                Telefon = "+38762345678",
                KorisnickoIme = "desktop2",
                LozinkaHash = "ctdN66Ftv+YJP9LAK6i3dKDqchg=",
                LozinkaSalt = "NSqADQ/R7xKWHlTVz2BMwg=="
            });
            #endregion

            #region UPOSLENICIULOGE
            modelBuilder.Entity<UposlenikUloge>().HasData(new UposlenikUloge()
            {
                UposlenikUlogeID=1,
                UposlenikID=1,
                UlogaID=1, 
                DatumIzmjene= new DateTime(2020, 6, 13, 20, 10, 26, 966, DateTimeKind.Local)

            });
            modelBuilder.Entity<UposlenikUloge>().HasData(new UposlenikUloge()
            {
                UposlenikUlogeID = 2,
                UposlenikID = 2,
                UlogaID = 2,
                DatumIzmjene = new DateTime(2020, 6, 13, 20, 10, 26, 966, DateTimeKind.Local)
            });
            #endregion

            #region SVRHA
            modelBuilder.Entity<Svrha>().HasData(new Svrha()
            {
                SvrhaID = 1,
                Naziv = "Kupovina"
            });
            modelBuilder.Entity<Svrha>().HasData(new Svrha()
            {
                SvrhaID = 2,
                Naziv = "Uredjivanje vrtova/parkova"
            });
            modelBuilder.Entity<Svrha>().HasData(new Svrha()
            {
                SvrhaID = 3,
                Naziv = "Aranzman"
            });
            #endregion

            #region KATEGORIJA
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 1,
                Naziv = "Jednogodišnja",
                Opis = "Jednogodišnjim biljkama se cijeli životni ciklus odvija u toku jednog vegetacijskog perioda."
            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 2,
                Naziv = "Višegodišnja",
                Opis = "Višegodišnja biljka je biljka koja živi duže od dvije godine."
            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 3,
                Naziv = "Listopadne",
                Opis = "Listopadne biljke su sve vrste biljaka koje gube svoje listove pred nastupajući nepovoljni period."
            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 4,
                Naziv = "Zimzelene",
                Opis = "Zimzelene biljke predstavljaju dominantni dio rasprostranjen po cijeloj Zemlji."
            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 5,
                Naziv = "Crnogorične",
                Opis = "Crnogoričnim šumama nazivamo šume koje ne odbacuje lišće, nego ga zadržava cijele godine."
            });
            #endregion

            #region GRADOVI
            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradID = 1,
                Naziv = "Sarajevo"
            });
            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradID = 2,
                Naziv = "Tuzla"
            });
            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradID= 3,
                Naziv = "Zenica"
            });
            #endregion

            #region BILJKE
            modelBuilder.Entity<Biljke>().HasData(new Biljke()
            {
                BiljkeID = 1,
                KategorijaID = 1,
                Naziv = "Petunija",
                Opis = "Petunija pripada porodici pomoćnica,porijeklom iz Južne Amerike.",
                Slika = "1.jpg",
                Cijena = 1
            });
            modelBuilder.Entity<Biljke>().HasData(new Biljke()
            {
                BiljkeID = 2,
                KategorijaID = 2,
                Naziv = "Lavanda ",
                Opis = "Lavanda cvati u proljeće i u jesen ukoliko se dobro podreže nakon prve cvatnje.",
                Slika = "2.jpg",
                Cijena = 3
            });
            modelBuilder.Entity<Biljke>().HasData(new Biljke()
            {
                BiljkeID = 3,
                KategorijaID = 3,
                Naziv = "Kesten",
                Opis = "Pitomi kesten (Castanea sativa) je listopadno stablo iz porodice bukvi.",
                Slika = "3.jpg",
                Cijena = 65
            });
            modelBuilder.Entity<Biljke>().HasData(new Biljke()
            {
                BiljkeID = 4,
                KategorijaID = 4,
                Naziv = "Patuljasta kleka",
                Opis = "Patuljak smreka je jedna od mnogo varijanti ove zimzelene biljke koja obično raste kao grm.",
                Slika = "4.jpg",
                Cijena = 50
            });
            modelBuilder.Entity<Biljke>().HasData(new Biljke()
            {
                BiljkeID = 5,
                KategorijaID = 5,
                Naziv = "Planinski bor",
                Opis = "Planinski bor, klekovina ili bor krivulj je crnogorična vrsta drveća iz porodice Pinaceae.",
                Slika = "5.jpg",
                Cijena = 45
            });
            #endregion

            #region KORISNIK
            modelBuilder.Entity<Korisnik>().HasData(new Korisnik()
            {
                KorisnikID = 1,
                Ime = "Mobile",
                Prezime = "Mobile",
                DatumRodjenja = DateTime.Now,
                Email = "korisnik@live.com",
                Telefon = "+38762345678",
                KorisnickoIme = "mobile",
                LozinkaHash = "bUBHhasx3aUpr7cmjozMzIeL35c=",
                LozinkaSalt = "zthomrUyhZjeapvj5KYL+A=="
            });
            modelBuilder.Entity<Korisnik>().HasData(new Korisnik()
            {
                KorisnikID = 2,
                Ime = "Adnan",
                Prezime = "Pobric",
                DatumRodjenja = DateTime.Now,
                Email = "adnan@live.com",
                Telefon = "+38762345676",
                KorisnickoIme = "adnan",
                LozinkaHash = "bUBHhasx3aUpr7cmjozMzIeL35c=",
                LozinkaSalt = "zthomrUyhZjeapvj5KYL+A=="
            });
            #endregion

            #region REZERVACIJE
            modelBuilder.Entity<Rezervacije>().HasData(new Rezervacije()
            {
                RezervacijaID = 1,
                DatumRezervacije = new DateTime(2022,05,06),
                KorisnikID = 1,
                GradID = 1,
                Napomena = "",
                Kolicina = 2,
                SvrhaID = 1,
                BiljkeID = 1,
                AdresaDostave = "Ćamila Sijarića"
            });
            modelBuilder.Entity<Rezervacije>().HasData(new Rezervacije()
            {
                RezervacijaID = 2,
                DatumRezervacije = new DateTime(2022, 04, 06),
                KorisnikID = 2,
                GradID = 2,
                Napomena = "Dostava na adresu",
                Kolicina = 1,
                SvrhaID = 2,
                BiljkeID = 2,
                AdresaDostave = "Azize Šaćirbegović"
            });
            modelBuilder.Entity<Rezervacije>().HasData(new Rezervacije()
            {
                RezervacijaID = 3,
                DatumRezervacije = new DateTime(2022, 04, 10),
                KorisnikID = 1,
                GradID = 1,
                Napomena = "Placanje pri preuzimanju",
                Kolicina = 3,
                SvrhaID = 1,
                BiljkeID = 3,
                AdresaDostave = "Nedima Filipovića"
            });
            modelBuilder.Entity<Rezervacije>().HasData(new Rezervacije()
            {
                RezervacijaID = 4,
                DatumRezervacije = new DateTime(2022, 05, 10),
                KorisnikID = 2,
                GradID = 3,
                Napomena = "Placanje pri preuzimanju",
                Kolicina = 4,
                SvrhaID = 3,
                BiljkeID = 4,
                AdresaDostave = "Hasana Brkića"
            });
            #endregion

            #region DOSTAVA
            modelBuilder.Entity<Dostava>().HasData(new Dostava()
            {
                DostavaID = 1,
                DatumSlanja = new DateTime(2022, 05, 06),
                DatumPreuzimanja = new DateTime(2022, 05, 07),
                TrenutnaLokacija = "Sremska",
                Napomena = "Dostava kasni 5min",
                RezervacijaID = 1
            });
            modelBuilder.Entity<Dostava>().HasData(new Dostava()
            {
                DostavaID = 2,
                DatumSlanja = new DateTime(2022, 04, 06),
                DatumPreuzimanja = new DateTime(2022, 04, 06),
                TrenutnaLokacija = "Skadarska",
                Napomena = "",
                RezervacijaID = 2
            });
            modelBuilder.Entity<Dostava>().HasData(new Dostava()
            {
                DostavaID = 3,
                DatumSlanja = new DateTime(2022, 04, 10),
                DatumPreuzimanja = new DateTime(2022, 04, 10),
                TrenutnaLokacija = "Ranka Šipke",
                Napomena = "",
                RezervacijaID = 3
            });
            modelBuilder.Entity<Dostava>().HasData(new Dostava()
            {
                DostavaID = 4,
                DatumSlanja = new DateTime(2022, 05, 10),
                DatumPreuzimanja = new DateTime(2022, 05, 10),
                TrenutnaLokacija = "Oraščka",
                Napomena = "",
                RezervacijaID = 4
            });
            #endregion

            #region OCJENA
            modelBuilder.Entity<Ocjena>().HasData(new Ocjena()
            {
                OcjenaID = 1,
                BiljkeID = 1,
                KorisnikID = 1,
                OcjenaUsluge = 4
            });
            modelBuilder.Entity<Ocjena>().HasData(new Ocjena()
            {
                OcjenaID = 2,
                BiljkeID = 2,
                KorisnikID = 1,
                OcjenaUsluge = 5
            });
            modelBuilder.Entity<Ocjena>().HasData(new Ocjena()
            {
                OcjenaID = 3,
                BiljkeID = 3,
                KorisnikID = 2,
                OcjenaUsluge = 5
            });
            modelBuilder.Entity<Ocjena>().HasData(new Ocjena()
            {
                OcjenaID = 4,
                BiljkeID = 2,
                KorisnikID = 2,
                OcjenaUsluge = 4
            });
            #endregion

            #region PLACANJE
            modelBuilder.Entity<Placanje>().HasData(new Placanje()
            {
                PlacanjeID = 1,
                BrojKartice = 123445677,
                ExpMonth = 2,
                ExpYear = 23,
                KorisnikId = 1,
                SecurityCode = 123
            });
            modelBuilder.Entity<Placanje>().HasData(new Placanje()
            {
                PlacanjeID = 2,
                BrojKartice = 987654678,
                ExpMonth = 7,
                ExpYear = 25,
                KorisnikId = 2,
                SecurityCode = 134
            });           
            #endregion
        }
    }
}
