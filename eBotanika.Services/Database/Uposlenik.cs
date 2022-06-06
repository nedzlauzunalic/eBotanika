namespace eBotanika.Services.Database
{
    public partial class Uposlenik
    {
        public Uposlenik()
        {
            UposlenikUloge = new HashSet<UposlenikUloge>();
        }

        public int UposlenikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public virtual ICollection<UposlenikUloge> UposlenikUloge { get; set; }
    }
}
