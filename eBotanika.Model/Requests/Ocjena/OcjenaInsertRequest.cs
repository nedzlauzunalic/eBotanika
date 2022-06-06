namespace eBotanika.Model.Requests.Ocjena
{
    public class OcjenaInsertRequest
    {
        public decimal OcjenaUsluge { get; set; }
        public int KorisnikID { get; set; }
        public int BiljkeID { get; set; }
    }
}
