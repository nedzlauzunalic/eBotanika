using eBotanika.Model.Requests.Svrha;

namespace eBotanika.Services.Svrha
{
    public interface ISvrhaService
    {
       List<Model.Svrha> Get(SvrhaSearchRequest request);

       Model.Svrha GetById(int id);
    }
}
