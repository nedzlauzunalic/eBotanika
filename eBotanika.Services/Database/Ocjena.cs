namespace eBotanika.Services.Database
{
    public partial class Ocjena
    {
        public int OcjenaID { get; set; }
        public decimal OcjenaUsluge { get; set; }
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
        public int BiljkeID { get; set; }
        public Biljke Biljke { get; set; }
    }
}
