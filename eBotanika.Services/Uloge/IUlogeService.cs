using eBotanika.Model.Requests.Uloge;

namespace eBotanika.Services.Uloge
{
    public interface IUlogeService
    {
        List<Model.Uloge> Get(UlogeSearchRequest request);
    }
}
