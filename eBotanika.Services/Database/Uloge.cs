namespace eBotanika.Services.Database
{
    public partial class Uloge
    {
        public Uloge()
        {
            Uposlenik = new HashSet<Uposlenik>();
        }
        public int UlogaID { get; set; }
        public string Naziv { get; set; }
        public virtual ICollection<Uposlenik> Uposlenik { get; set; }
    }
}
