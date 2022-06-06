using eBotanika.Model.Requests.Placanje;

namespace eBotanika.Services.Placanje
{
    public interface IPlacanjeService
    {
        public List<Model.Placanje> Get(PlacanjeSearchRequest request);

        public Model.Placanje Insert(PlacanjeInsertRequest request);

        public Model.Placanje Delete(int id);
    }
}
