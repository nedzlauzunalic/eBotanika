﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eBotanika.Services.Database;

#nullable disable

namespace eBotanika.Services.Migrations
{
    [DbContext(typeof(eBotanikaContext))]
    partial class eBotanikaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eBotanika.Services.Database.Biljke", b =>
                {
                    b.Property<int>("BiljkeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BiljkeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BiljkeID"), 1L, 1);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KategorijaID")
                        .HasColumnType("int")
                        .HasColumnName("KategorijaID");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Slika")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UposlenikID")
                        .HasColumnType("int");

                    b.HasKey("BiljkeID");

                    b.HasIndex("KategorijaID");

                    b.HasIndex("UposlenikID");

                    b.ToTable("Biljke");

                    b.HasData(
                        new
                        {
                            BiljkeID = 1,
                            Cijena = 100m,
                            KategorijaID = 1,
                            Naziv = "Petunija",
                            Opis = "Petunija pripada porodici pomoćnica,porijeklom iz Južne Amerike.",
                            Slika = "1.jpg",
                            UposlenikID = 1
                        },
                        new
                        {
                            BiljkeID = 2,
                            Cijena = 150m,
                            KategorijaID = 2,
                            Naziv = "Lavanda ",
                            Opis = "Lavanda cvati u proljeće i u jesen ukoliko se dobro podreže nakon prve cvatnje.",
                            Slika = "2.jpg",
                            UposlenikID = 1
                        },
                        new
                        {
                            BiljkeID = 3,
                            Cijena = 270m,
                            KategorijaID = 3,
                            Naziv = "Kesten",
                            Opis = "Pitomi kesten (Castanea sativa) je listopadno stablo iz porodice bukvi.",
                            Slika = "3.jpg",
                            UposlenikID = 1
                        },
                        new
                        {
                            BiljkeID = 4,
                            Cijena = 180m,
                            KategorijaID = 4,
                            Naziv = "Patuljasta kleka",
                            Opis = "Patuljak smreka je jedna od mnogo varijanti ove zimzelene biljke koja obično raste kao grm.",
                            Slika = "4.jpg",
                            UposlenikID = 1
                        },
                        new
                        {
                            BiljkeID = 5,
                            Cijena = 138m,
                            KategorijaID = 5,
                            Naziv = "Planinski bor",
                            Opis = "Planinski bor, klekovina ili bor krivulj je crnogorična vrsta drveća iz porodice Pinaceae.",
                            Slika = "5.jpg",
                            UposlenikID = 1
                        });
                });

            modelBuilder.Entity("eBotanika.Services.Database.Dostava", b =>
                {
                    b.Property<int?>("DostavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DostavaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("DostavaID"), 1L, 1);

                    b.Property<DateTime?>("DatumPreuzimanja")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DatumSlanja")
                        .HasColumnType("datetime");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Napomena")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("RezervacijaID")
                        .HasColumnType("int")
                        .HasColumnName("RezervacijaID");

                    b.Property<string>("TrenutnaLokacija")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DostavaID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("RezervacijaID");

                    b.ToTable("Dostava");

                    b.HasData(
                        new
                        {
                            DostavaID = 1,
                            DatumPreuzimanja = new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DatumSlanja = new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KorisnikID = 1,
                            Napomena = "Dostava kasni 5min",
                            RezervacijaID = 1,
                            TrenutnaLokacija = "Sremska"
                        },
                        new
                        {
                            DostavaID = 2,
                            DatumPreuzimanja = new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DatumSlanja = new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KorisnikID = 2,
                            Napomena = "",
                            RezervacijaID = 2,
                            TrenutnaLokacija = "Skadarska"
                        },
                        new
                        {
                            DostavaID = 3,
                            DatumPreuzimanja = new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DatumSlanja = new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KorisnikID = 1,
                            Napomena = "",
                            RezervacijaID = 3,
                            TrenutnaLokacija = "Ranka Šipke"
                        },
                        new
                        {
                            DostavaID = 4,
                            DatumPreuzimanja = new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DatumSlanja = new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KorisnikID = 2,
                            Napomena = "",
                            RezervacijaID = 4,
                            TrenutnaLokacija = "Oraščka"
                        });
                });

            modelBuilder.Entity("eBotanika.Services.Database.Gradovi", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GradID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("GradID");

                    b.ToTable("Gradovi");

                    b.HasData(
                        new
                        {
                            GradID = 1,
                            Naziv = "Sarajevo"
                        },
                        new
                        {
                            GradID = 2,
                            Naziv = "Tuzla"
                        },
                        new
                        {
                            GradID = 3,
                            Naziv = "Zenica"
                        });
                });

            modelBuilder.Entity("eBotanika.Services.Database.Kategorija", b =>
                {
                    b.Property<int>("KategorijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KategorijaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategorijaID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("KategorijaID");

                    b.ToTable("Kategorija");

                    b.HasData(
                        new
                        {
                            KategorijaID = 1,
                            Naziv = "Jednogodišnja",
                            Opis = "Jednogodišnjim biljkama se cijeli životni ciklus odvija u toku jednog vegetacijskog perioda."
                        },
                        new
                        {
                            KategorijaID = 2,
                            Naziv = "Višegodišnja",
                            Opis = "Višegodišnja biljka je biljka koja živi duže od dvije godine."
                        },
                        new
                        {
                            KategorijaID = 3,
                            Naziv = "Listopadne",
                            Opis = "Listopadne biljke su sve vrste biljaka koje gube svoje listove pred nastupajući nepovoljni period."
                        },
                        new
                        {
                            KategorijaID = 4,
                            Naziv = "Zimzelene",
                            Opis = "Zimzelene biljke predstavljaju dominantni dio rasprostranjen po cijeloj Zemlji."
                        },
                        new
                        {
                            KategorijaID = 5,
                            Naziv = "Crnogorične",
                            Opis = "Crnogoričnim šumama nazivamo šume koje ne odbacuje lišće, nego ga zadržava cijele godine."
                        });
                });

            modelBuilder.Entity("eBotanika.Services.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikID"), 1L, 1);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("KorisnikID");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("Korisnik_Email");

                    b.ToTable("Korisnik");

                    b.HasData(
                        new
                        {
                            KorisnikID = 1,
                            DatumRodjenja = new DateTime(2022, 8, 30, 12, 12, 40, 529, DateTimeKind.Local).AddTicks(5409),
                            Email = "korisnik@live.com",
                            Ime = "Mobile",
                            KorisnickoIme = "mobile",
                            LozinkaHash = "bUBHhasx3aUpr7cmjozMzIeL35c=",
                            LozinkaSalt = "zthomrUyhZjeapvj5KYL+A==",
                            Prezime = "Mobile",
                            Telefon = "+38762345678"
                        },
                        new
                        {
                            KorisnikID = 2,
                            DatumRodjenja = new DateTime(2022, 8, 30, 12, 12, 40, 529, DateTimeKind.Local).AddTicks(5444),
                            Email = "adnan@live.com",
                            Ime = "Adnan",
                            KorisnickoIme = "adnan",
                            LozinkaHash = "bUBHhasx3aUpr7cmjozMzIeL35c=",
                            LozinkaSalt = "zthomrUyhZjeapvj5KYL+A==",
                            Prezime = "Pobric",
                            Telefon = "+38762345676"
                        });
                });

            modelBuilder.Entity("eBotanika.Services.Database.Ocjena", b =>
                {
                    b.Property<int>("OcjenaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OcjenaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OcjenaID"), 1L, 1);

                    b.Property<int>("BiljkeID")
                        .HasColumnType("int")
                        .HasColumnName("BiljkeID");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.Property<decimal>("OcjenaUsluge")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OcjenaID");

                    b.HasIndex("BiljkeID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Ocjena");

                    b.HasData(
                        new
                        {
                            OcjenaID = 1,
                            BiljkeID = 1,
                            KorisnikID = 1,
                            OcjenaUsluge = 4m
                        },
                        new
                        {
                            OcjenaID = 2,
                            BiljkeID = 2,
                            KorisnikID = 1,
                            OcjenaUsluge = 5m
                        },
                        new
                        {
                            OcjenaID = 3,
                            BiljkeID = 3,
                            KorisnikID = 2,
                            OcjenaUsluge = 5m
                        },
                        new
                        {
                            OcjenaID = 4,
                            BiljkeID = 2,
                            KorisnikID = 2,
                            OcjenaUsluge = 4m
                        });
                });

            modelBuilder.Entity("eBotanika.Services.Database.Placanje", b =>
                {
                    b.Property<int>("PlacanjeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PlacanjeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlacanjeID"), 1L, 1);

                    b.Property<string>("BrojTransakcije")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Iznos")
                        .HasColumnType("float");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.HasKey("PlacanjeID");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Placanje");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Rezervacije", b =>
                {
                    b.Property<int>("RezervacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RezervacijaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RezervacijaID"), 1L, 1);

                    b.Property<string>("AdresaDostave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BiljkeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumRezervacije")
                        .HasColumnType("datetime");

                    b.Property<int>("GradID")
                        .HasColumnType("int")
                        .HasColumnName("GradID");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.Property<string>("Napomena")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SvrhaID")
                        .HasColumnType("int")
                        .HasColumnName("SvrhaID");

                    b.HasKey("RezervacijaID");

                    b.HasIndex("BiljkeID");

                    b.HasIndex("GradID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("SvrhaID");

                    b.ToTable("Rezervacije");

                    b.HasData(
                        new
                        {
                            RezervacijaID = 1,
                            AdresaDostave = "Ćamila Sijarića",
                            BiljkeID = 1,
                            DatumRezervacije = new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GradID = 1,
                            Kolicina = 2,
                            KorisnikID = 1,
                            Napomena = "",
                            SvrhaID = 1
                        },
                        new
                        {
                            RezervacijaID = 2,
                            AdresaDostave = "Azize Šaćirbegović",
                            BiljkeID = 2,
                            DatumRezervacije = new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GradID = 2,
                            Kolicina = 1,
                            KorisnikID = 2,
                            Napomena = "Dostava na adresu",
                            SvrhaID = 2
                        },
                        new
                        {
                            RezervacijaID = 3,
                            AdresaDostave = "Nedima Filipovića",
                            BiljkeID = 3,
                            DatumRezervacije = new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GradID = 1,
                            Kolicina = 3,
                            KorisnikID = 1,
                            Napomena = "Placanje pri preuzimanju",
                            SvrhaID = 1
                        },
                        new
                        {
                            RezervacijaID = 4,
                            AdresaDostave = "Hasana Brkića",
                            BiljkeID = 4,
                            DatumRezervacije = new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GradID = 3,
                            Kolicina = 4,
                            KorisnikID = 2,
                            Napomena = "Placanje pri preuzimanju",
                            SvrhaID = 3
                        });
                });

            modelBuilder.Entity("eBotanika.Services.Database.Svrha", b =>
                {
                    b.Property<int>("SvrhaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SvrhaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SvrhaID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SvrhaID");

                    b.ToTable("Svrha");

                    b.HasData(
                        new
                        {
                            SvrhaID = 1,
                            Naziv = "Kupovina"
                        },
                        new
                        {
                            SvrhaID = 2,
                            Naziv = "Uredjivanje vrtova/parkova"
                        },
                        new
                        {
                            SvrhaID = 3,
                            Naziv = "Aranzman"
                        });
                });

            modelBuilder.Entity("eBotanika.Services.Database.Uloge", b =>
                {
                    b.Property<int>("UlogaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UlogaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UlogaID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UlogaID");

                    b.ToTable("Uloge");

                    b.HasData(
                        new
                        {
                            UlogaID = 1,
                            Naziv = "Administrator"
                        },
                        new
                        {
                            UlogaID = 2,
                            Naziv = "Radnik"
                        });
                });

            modelBuilder.Entity("eBotanika.Services.Database.Uposlenik", b =>
                {
                    b.Property<int>("UposlenikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UposlenikID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UposlenikID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UlogaID")
                        .HasColumnType("int");

                    b.HasKey("UposlenikID");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("Korisnik_Email");

                    b.HasIndex("UlogaID");

                    b.ToTable("Uposlenik");

                    b.HasData(
                        new
                        {
                            UposlenikID = 1,
                            Email = "admin@live.com",
                            Ime = "Admin",
                            KorisnickoIme = "desktop",
                            LozinkaHash = "bUBHhasx3aUpr7cmjozMzIeL35c=",
                            LozinkaSalt = "zthomrUyhZjeapvj5KYL+A==",
                            Prezime = "Admin",
                            Telefon = "+38762123456",
                            UlogaID = 1
                        },
                        new
                        {
                            UposlenikID = 2,
                            Email = "radnik1@live.com",
                            Ime = "Radnik1",
                            KorisnickoIme = "desktop2",
                            LozinkaHash = "ctdN66Ftv+YJP9LAK6i3dKDqchg=",
                            LozinkaSalt = "NSqADQ/R7xKWHlTVz2BMwg==",
                            Prezime = "Radnik1",
                            Telefon = "+38762345678",
                            UlogaID = 2
                        });
                });

            modelBuilder.Entity("eBotanika.Services.Database.Biljke", b =>
                {
                    b.HasOne("eBotanika.Services.Database.Kategorija", "Kategorija")
                        .WithMany("Biljke")
                        .HasForeignKey("KategorijaID")
                        .IsRequired()
                        .HasConstraintName("FK_Biljke_Kategorija");

                    b.HasOne("eBotanika.Services.Database.Uposlenik", "Uposlenik")
                        .WithMany("Biljke")
                        .HasForeignKey("UposlenikID")
                        .IsRequired()
                        .HasConstraintName("FK_Biljke_Uposlenik");

                    b.Navigation("Kategorija");

                    b.Navigation("Uposlenik");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Dostava", b =>
                {
                    b.HasOne("eBotanika.Services.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID");

                    b.HasOne("eBotanika.Services.Database.Rezervacije", "Rezervacije")
                        .WithMany("Dostava")
                        .HasForeignKey("RezervacijaID")
                        .HasConstraintName("FK_Dostava_Rezervacije");

                    b.Navigation("Korisnik");

                    b.Navigation("Rezervacije");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Ocjena", b =>
                {
                    b.HasOne("eBotanika.Services.Database.Biljke", "Biljke")
                        .WithMany("Ocjena")
                        .HasForeignKey("BiljkeID")
                        .IsRequired()
                        .HasConstraintName("FK_Ocjena_Biljke");

                    b.HasOne("eBotanika.Services.Database.Korisnik", "Korisnik")
                        .WithMany("Ocjena")
                        .HasForeignKey("KorisnikID")
                        .IsRequired()
                        .HasConstraintName("FK_Ocjena_Korisnik");

                    b.Navigation("Biljke");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Placanje", b =>
                {
                    b.HasOne("eBotanika.Services.Database.Korisnik", "Korisnik")
                        .WithMany("Placanje")
                        .HasForeignKey("KorisnikId")
                        .IsRequired()
                        .HasConstraintName("FK_Placanje_Korisnik");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Rezervacije", b =>
                {
                    b.HasOne("eBotanika.Services.Database.Biljke", "Biljke")
                        .WithMany("Rezervacije")
                        .HasForeignKey("BiljkeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBotanika.Services.Database.Gradovi", "Grad")
                        .WithMany("Rezervacije")
                        .HasForeignKey("GradID")
                        .IsRequired()
                        .HasConstraintName("FK_Rezervacije_Grad");

                    b.HasOne("eBotanika.Services.Database.Korisnik", "Korisnik")
                        .WithMany("Rezervacije")
                        .HasForeignKey("KorisnikID")
                        .IsRequired()
                        .HasConstraintName("FK_Rezervacije_Korisnik");

                    b.HasOne("eBotanika.Services.Database.Svrha", "Svrha")
                        .WithMany("Rezervacije")
                        .HasForeignKey("SvrhaID")
                        .IsRequired()
                        .HasConstraintName("FK_Rezervacije_Svrha");

                    b.Navigation("Biljke");

                    b.Navigation("Grad");

                    b.Navigation("Korisnik");

                    b.Navigation("Svrha");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Uposlenik", b =>
                {
                    b.HasOne("eBotanika.Services.Database.Uloge", "Uloge")
                        .WithMany("Uposlenik")
                        .HasForeignKey("UlogaID")
                        .IsRequired()
                        .HasConstraintName("FK_Uposlenik_Uloge");

                    b.Navigation("Uloge");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Biljke", b =>
                {
                    b.Navigation("Ocjena");

                    b.Navigation("Rezervacije");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Gradovi", b =>
                {
                    b.Navigation("Rezervacije");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Kategorija", b =>
                {
                    b.Navigation("Biljke");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Korisnik", b =>
                {
                    b.Navigation("Ocjena");

                    b.Navigation("Placanje");

                    b.Navigation("Rezervacije");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Rezervacije", b =>
                {
                    b.Navigation("Dostava");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Svrha", b =>
                {
                    b.Navigation("Rezervacije");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Uloge", b =>
                {
                    b.Navigation("Uposlenik");
                });

            modelBuilder.Entity("eBotanika.Services.Database.Uposlenik", b =>
                {
                    b.Navigation("Biljke");
                });
#pragma warning restore 612, 618
        }
    }
}
