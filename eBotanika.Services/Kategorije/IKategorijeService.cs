using eBotanika.Model.Requests.Kategorije;

namespace eBotanika.Services.Kategorije
{
    public interface IKategorijeService
    {
        IEnumerable<Model.Kategorija> Get();

        Model.Kategorija GetById(int id);

        Model.Kategorija Insert(KategorijeInsertRequest request);

        Model.Kategorija Update(int id, KategorijeInsertRequest request);
    }
}
