﻿namespace eBotanika.Model.Requests.Dostava
{
    public class DostavaInsertRequest
    {
        public string DatumSlanja { get; set; }
        public string DatumPreuzimanja { get; set; }
        public string TrenutnaLokacija { get; set; }
        public string Napomena { get; set; }
        public string RezervacijaID { get; set; }
        public string KorisnikID { get; set; }
    }
}
