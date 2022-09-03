namespace eBotanika.Services.Database
{
    public partial class Ocjena
    {
        public Ocjena()
        {
            Rezervacije = new HashSet<Rezervacije>();
        }
        public int OcjenaID { get; set; }
        public decimal OcjenaUsluge { get; set; }
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
        public int BiljkeID { get; set; }
        public Biljke Biljke { get; set; }
        public ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
