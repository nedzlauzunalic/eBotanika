namespace eBotanika.Services.Database
{
    public partial class Placanje
    {
        public int PlacanjeID { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public int BrojKartice { get; set; }
        public int SecurityCode { get; set; }
        public int ExpYear { get; set; }
        public int ExpMonth { get; set; }
    }
}
