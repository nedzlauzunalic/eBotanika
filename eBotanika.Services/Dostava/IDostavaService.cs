using eBotanika.Model.Requests.Dostava;

namespace eBotanika.Services.Dostava
{
    public interface IDostavaService
    {
        public List<Model.Dostava> Get(DostavaSearchRequest request);

        public Model.Dostava Insert(DostavaInsertRequest request);

        public Model.Dostava Update(int id, DostavaInsertRequest request);

        public Model.Dostava GetById(int id);

        public Model.Dostava Delete(int id);
    }
}
