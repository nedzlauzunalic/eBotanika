using Microsoft.EntityFrameworkCore;

namespace eBotanika.Services.Database
{
    public partial class eBotanikaContext : DbContext
    {
        public eBotanikaContext()
        {
        }

        public eBotanikaContext(DbContextOptions<eBotanikaContext> options) : base(options)
        {
        }

        public virtual DbSet<Biljke> Biljke { get; set; }
        public virtual DbSet<Dostava> Dostava { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Ocjena> Ocjena { get; set; }
        public virtual DbSet<Placanje> Placanje { get; set; }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<Svrha> Svrha { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<Uposlenik> Uposlenik { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Biljke>(entity =>
            {
                entity.HasKey(e => e.BiljkeID);

                entity.Property(e => e.BiljkeID).HasColumnName("BiljkeID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Slika)
                    .HasMaxLength(100);

                entity.Property(e => e.KategorijaID).HasColumnName("KategorijaID");

                entity.HasOne(d => d.Kategorija)
                   .WithMany(p => p.Biljke)
                   .HasForeignKey(d => d.KategorijaID)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Biljke_Kategorija");

                entity.HasOne(d => d.Uposlenik)
                      .WithMany(p => p.Biljke)
                      .HasForeignKey(d => d.UposlenikID)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Biljke_Uposlenik");

            });

            modelBuilder.Entity<Dostava>(entity =>
            {
                entity.HasKey(e => e.DostavaID);

                entity.Property(e => e.DostavaID).HasColumnName("DostavaID");

                entity.Property(e => e.DatumSlanja).HasColumnType("datetime");

                entity.Property(e => e.DatumPreuzimanja).HasColumnType("datetime");

                entity.Property(e => e.TrenutnaLokacija)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Napomena)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RezervacijaID).HasColumnName("RezervacijaID");

                entity.HasOne(d => d.Rezervacije)
                   .WithMany(p => p.Dostava)
                   .HasForeignKey(d => d.RezervacijaID)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Dostava_Rezervacije");
            });

            modelBuilder.Entity<Gradovi>(entity =>
            {
                entity.HasKey(e => e.GradID);

                entity.Property(e => e.GradID).HasColumnName("GradID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.HasKey(e => e.KategorijaID);

                entity.Property(e => e.KategorijaID).HasColumnName("KategorijaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.HasKey(e => e.KorisnikID);

                entity.Property(e => e.KorisnikID).HasColumnName("KorisnikID");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.HasIndex(e => e.Email)
                    .HasName("Korisnik_Email")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(100);

            });

            modelBuilder.Entity<Ocjena>(entity =>
            {
                entity.HasKey(e => e.OcjenaID);

                entity.Property(e => e.OcjenaID).HasColumnName("OcjenaID");

                entity.Property(e => e.OcjenaUsluge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KorisnikID).HasColumnName("KorisnikID");

                entity.HasOne(d => d.Korisnik)
                   .WithMany(p => p.Ocjena)
                   .HasForeignKey(d => d.KorisnikID)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Ocjena_Korisnik");

                entity.Property(e => e.BiljkeID).HasColumnName("BiljkeID");

                entity.HasOne(d => d.Biljke)
                   .WithMany(p => p.Ocjena)
                   .HasForeignKey(d => d.BiljkeID)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Ocjena_Biljke");
            });

            modelBuilder.Entity<Placanje>(entity =>
            {
                entity.HasKey(e => e.PlacanjeID);

                entity.Property(e => e.PlacanjeID).HasColumnName("PlacanjeID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Placanje)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Placanje_Korisnik");
            });

            modelBuilder.Entity<Rezervacije>(entity =>
            {
                entity.HasKey(e => e.RezervacijaID);

                entity.Property(e => e.RezervacijaID).HasColumnName("RezervacijaID");

                entity.Property(e => e.DatumRezervacije).HasColumnType("datetime");

                entity.Property(e => e.KorisnikID).HasColumnName("KorisnikID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.KorisnikID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Korisnik");

                entity.Property(e => e.GradID).HasColumnName("GradID");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.GradID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Grad");

                entity.Property(e => e.Napomena)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SvrhaID).HasColumnName("SvrhaID");

                entity.Property(e => e.OcjenaUsluge).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Svrha)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.SvrhaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Svrha");

                entity.Property(e => e.BiljkeID).HasColumnName("BiljkeID");

                entity.HasOne(d => d.Biljke)
                      .WithMany(p => p.Rezervacije)
                      .HasForeignKey(d => d.BiljkeID)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Rezervacije_Biljke");

                entity.Property(e => e.OcjenaID).HasColumnName("OcjenaID");

                entity.HasOne(d => d.Ocjena)
                      .WithMany(p => p.Rezervacije)
                      .HasForeignKey(d => d.OcjenaID)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Rezervacije_Ocjena");
            });

            modelBuilder.Entity<Svrha>(entity =>
            {
                entity.HasKey(e => e.SvrhaID);

                entity.Property(e => e.SvrhaID).HasColumnName("SvrhaID");

                entity.Property(e => e.Naziv)
                      .IsRequired()
                      .HasMaxLength(50);

            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaID);

                entity.Property(e => e.UlogaID).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                      .IsRequired()
                      .HasMaxLength(50);

            });

            modelBuilder.Entity<Uposlenik>(entity =>
            {
                entity.HasKey(e => e.UposlenikID);

                entity.Property(e => e.UposlenikID).HasColumnName("UposlenikID");

                entity.Property(e => e.Ime)
                   .IsRequired()
                   .HasMaxLength(100);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.Email)
                    .HasName("Korisnik_Email")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Uloge)
                      .WithMany(p => p.Uposlenik)
                      .HasForeignKey(d => d.UlogaID)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Uposlenik_Uloge");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
