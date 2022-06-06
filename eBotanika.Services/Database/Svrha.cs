namespace eBotanika.Services.Database
{
    public partial class Svrha
    {
        public Svrha()
        {
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int SvrhaID { get; set; }
        public string Naziv { get; set; }
        public ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
