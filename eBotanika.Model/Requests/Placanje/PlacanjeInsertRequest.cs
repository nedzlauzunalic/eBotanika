namespace eBotanika.Model.Requests.Placanje
{
    public class PlacanjeInsertRequest
    {
        public int KorisnikId { get; set; }
        public string BrojTransakcije { get; set; }
        public string Currency { get; set; }
        public double Iznos { get; set; }
    }
}
