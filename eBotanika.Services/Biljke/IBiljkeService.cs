using eBotanika.Model.Requests.Biljke;

namespace eBotanika.Services.Biljke
{
    public interface IBiljkeService
    {
        List<Model.Biljke> Get(BiljkeSearchRequest request);

        Model.Biljke GetById(int id);

        Model.Biljke Insert(BiljkeInsertRequest request);

        Model.Biljke Update(int id, BiljkeInsertRequest request);

        Model.Biljke Delete(int id);
    }
}
