namespace eBotanika.Services.Database
{
    public partial class Uloge
    {
        public Uloge()
        {
            UposlenikUloge = new HashSet<UposlenikUloge>();
        }

        public int UlogaID { get; set; }
        public string Naziv { get; set; }
        public ICollection<UposlenikUloge> UposlenikUloge { get; set; }
    }
}
