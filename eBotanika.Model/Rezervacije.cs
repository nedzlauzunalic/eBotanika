namespace eBotanika.Model
{
    public class Rezervacije
    {
        public int RezervacijaID { get; set; }
        public string DatumRezervacije { get; set; }
        public int KorisnikID { get; set; }
        public int GradID { get; set; }
        public string Napomena { get; set; }
        public int SvrhaID { get; set; }
        public string AdresaDostave { get; set; }
        public string Kolicina { get; set; }
        public int BiljkeID { get; set; }
        public int OcjenaID { get; set; }
    }
}
