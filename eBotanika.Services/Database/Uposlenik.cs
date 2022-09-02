namespace eBotanika.Services.Database
{
    public partial class Uposlenik
    {
        public Uposlenik()
        {
            Biljke = new HashSet<Biljke>();
        }

        public int UposlenikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public int UlogaID { get; set; }
        public virtual Uloge Uloge { get; set; }
        public virtual ICollection<Biljke> Biljke { get; set; }
    }
}
