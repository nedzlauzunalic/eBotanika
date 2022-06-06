using eBotanika.Model.Requests.Korisnik;

namespace eBotanika.Services.Korisnik
{
    public interface IKorisnikService
    {
        List<Model.Korisnik> Get(KorisnikSearchRequest request);

        Model.Korisnik GetById(int id);

        Model.Korisnik Insert(KorisnikInsertRequest request);

        Model.Korisnik Update(int id, KorisnikInsertRequest request);

        Model.Korisnik Authenticiraj(string username, string pass);

        Model.Korisnik Delete(int id);
    }
}
