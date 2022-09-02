namespace eBotanika.Services.Database
{
    public partial class Biljke
    {
        public Biljke()
        {
            Ocjena = new HashSet<Ocjena>();
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int BiljkeID { get; set; }
        public int KategorijaID { get; set; }
        public Kategorija Kategorija { get; set; }
        public int UposlenikID { get; set; }
        public Uposlenik Uposlenik { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string? Slika { get; set; }
        public decimal Cijena { get; set; }
        public ICollection<Ocjena> Ocjena { get; set; }
        public ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
