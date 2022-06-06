namespace eBotanika.Services.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Biljke = new HashSet<Biljke>();
        }

        public int KategorijaID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public virtual ICollection<Biljke> Biljke { get; set; }
    }
}
