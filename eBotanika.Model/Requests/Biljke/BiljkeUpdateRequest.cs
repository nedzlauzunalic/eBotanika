namespace eBotanika.Model.Requests.Biljke
{
    public class BiljkeUpdateRequest
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Cijena { get; set; }
        public string KategorijaID { get; set; }
        public string UposlenikID { get; set; }
    }
}
