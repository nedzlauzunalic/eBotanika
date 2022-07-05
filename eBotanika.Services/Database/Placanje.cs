namespace eBotanika.Services.Database
{
    public partial class Placanje
    {
        public int PlacanjeID { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public string BrojTransakcije { get; set; }
        public string Currency { get; set; }
        public double Iznos { get; set; }
    }
}
