using System.Collections.Generic;

namespace eBotanika.Model
{
    public class Uposlenik
    {
        public int UposlenikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public ICollection<UposlenikUloge> UposlenikUloge { get; set; }
    }
}
