using eBotanika.Model.Requests.Ocjena;

namespace eBotanika.Services.Ocjena
{
    public interface IOcjenaService
    {
        List<Model.Ocjena> Get(OcjenaSearchRequest search);

        Model.Ocjena Insert(OcjenaInsertRequest request);

        Model.Ocjena Update(int id, OcjenaInsertRequest request);

        Model.Ocjena Delete(int id);
        List<Model.Ocjena> GetByKorisnikId(int korisnikid);
        Model.Ocjena GetById(int id);
    }
}
