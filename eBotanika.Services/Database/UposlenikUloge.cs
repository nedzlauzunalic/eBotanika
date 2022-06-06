namespace eBotanika.Services.Database
{
    public partial class UposlenikUloge
    {
        public int UposlenikUlogeID { get; set;}
        public int UposlenikID { get; set; }
        public int UlogaID { get; set; }
        public DateTime DatumIzmjene { get; set;}
        public Uposlenik Uposlenik { get; set; }
        public Uloge Uloga { get; set; }
    }
}
