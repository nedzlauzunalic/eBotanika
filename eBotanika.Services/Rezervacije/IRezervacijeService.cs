using eBotanika.Model.Requests.Rezervacije;

namespace eBotanika.Services.Rezervacije
{
    public interface IRezervacijeService
    {
        List<Model.Rezervacije> Get(RezervacijeSearchRequest request);

        Model.Rezervacije GetById(int id);

        List<Model.Rezervacije> GetByKorisnikId(int id);

        Model.Rezervacije Insert(RezervacijeInsertRequest request);

        Model.Rezervacije Update(int id, RezervacijeInsertRequest request);

        Model.Rezervacije Delete(int id);
    }
}
