namespace eBotanika.Model.Requests.Placanje
{
    public class PlacanjeInsertRequest
    {
        public int KorisnikId { get; set; }
        public int BrojKartice { get; set; }
        public int SecurityCode { get; set; }
        public int ExpYear { get; set; }
        public int ExpMonth { get; set; }
    }
}
