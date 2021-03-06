using System;

namespace eBotanika.Model
{
    public class Dostava
    {
        public int DostavaID { get; set; }
        public DateTime DatumSlanja { get; set; }
        public DateTime DatumPreuzimanja { get; set; }
        public string TrenutnaLokacija { get; set; }
        public string Napomena { get; set; }
        public int RezervacijaID { get; set; }
        public int KorisnikID { get; set; }
    }
}
