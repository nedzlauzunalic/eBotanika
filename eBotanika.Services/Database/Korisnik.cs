namespace eBotanika.Services.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Placanje = new HashSet<Placanje>();
            Ocjena = new HashSet<Ocjena>();
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public ICollection<Placanje> Placanje { get; set; }
        public ICollection<Rezervacije> Rezervacije { get; set; }
        public ICollection<Ocjena> Ocjena { get; set; }
    }
}
