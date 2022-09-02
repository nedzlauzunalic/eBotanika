namespace eBotanika.Model.Requests.Uposlenik
{
    public class UposlenikUpdateRequest
    {
        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public string KorisnickoIme { get; set; }

        public string Password { get; set; }

        public string PasswordPotvrda { get; set; }

        public string UlogaID { get; set; }
    }
}
