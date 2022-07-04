using eBotanika.Model.Requests.Dostava;

namespace eBotanika.Services.Dostava
{
    public interface IDostavaService
    {
       List<Model.Dostava> Get(DostavaSearchRequest request);

       Model.Dostava Insert(DostavaInsertRequest request);

       Model.Dostava Update(int id, DostavaInsertRequest request);

       List<Model.Dostava> GetById(int id);

       Model.Dostava Delete(int id);
    }
}
