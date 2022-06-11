namespace eBotanika.Model.Requests.Rezervacije
{
    public class RezervacijeInsertRequest
    {
        public int KorisnikID { get; set; }
        public int GradID { get; set; }
        public string DatumRezervacije { get; set; }
        public string Napomena { get; set; }
        public string SvrhaID { get; set; }
        public string AdresaDostave { get; set; }
        public string Kolicina { get; set; }
        public int BiljkeID { get; set; }
    }
}
