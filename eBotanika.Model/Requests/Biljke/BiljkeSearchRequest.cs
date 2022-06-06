namespace eBotanika.Model.Requests.Biljke
{
    public class BiljkeSearchRequest
    {
        public int? BiljkeID { get; set; }
        public int? KategorijaID { get; set; }
        public string Naziv { get; set; }
    }
}
