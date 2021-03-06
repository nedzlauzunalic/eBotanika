using System;

namespace eBotanika.Model.Requests.Korisnik
{
    public class KorisnikUpdateRequest
    {
        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public string DatumRodjenja { get; set; }

        public string KorisnickoIme { get; set; }

        public string Password { get; set; }

        public string PasswordPotvrda { get; set; }
    }
}
