using System;

namespace eBotanika.Model.Requests.Rezervacije
{
    public class RezervacijeSearchRequest
    {
        public int? RezervacijaId { get; set; }
        public int? KorisnikID { get; set; }
        public int? GradID { get; set; }
        public DateTime? DatumRezervacije { get; set; }
        public int? SvrhaID { get; set; }
        public int Kolicina { get; set; }
        public int? BiljkeID { get; set; }
    }
}
