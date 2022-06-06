namespace eBotanika.Services.Database
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int GradID { get; set; }
        public string Naziv { get; set; }
        public ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
