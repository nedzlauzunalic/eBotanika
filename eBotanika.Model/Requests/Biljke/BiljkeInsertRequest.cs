namespace eBotanika.Model.Requests.Biljke
{
    public class BiljkeInsertRequest
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Slika { get; set; }
        public string Cijena { get; set; }
        public string KategorijaID { get; set; }
        public string UposlenikID { get; set; }
    }
}
