namespace eBotanika.Model
{
    public class Biljke
    {
        public int BiljkeID { get; set; }
        public int KategorijaID { get; set; }
        public Kategorija Kategorija { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Slika { get; set; }
        public decimal Cijena { get; set; }
    }
}
