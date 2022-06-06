namespace eBotanika.Services.Database
{
    public partial class Rezervacije
    {
        public Rezervacije() {
            Dostava = new HashSet<Dostava>();
        }

        public int RezervacijaID { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
        public int GradID { get; set; }
        public Gradovi Grad { get; set; }
        public string Napomena { get; set; }
        public int Kolicina { get; set; }
        public int SvrhaID { get; set; }
        public Svrha Svrha { get; set; }
        public int BiljkeID { get; set; }
        public Biljke Biljke { get; set; }
        public ICollection<Dostava> Dostava { get; set; }
    }
}
