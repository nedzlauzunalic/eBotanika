using System;

namespace eBotanika.Model
{
    public class Rezervacije
    {
        public int RezervacijaID { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
        public int GradID { get; set; }
        public Gradovi Grad { get; set; }
        public string Napomena { get; set; }
        public int SvrhaID { get; set; }
        public Svrha Svrha { get; set; }
        public string Kolicina { get; set; }
        public int BiljkeID { get; set; }
        public Biljke Biljke { get; set; }
    }
}
