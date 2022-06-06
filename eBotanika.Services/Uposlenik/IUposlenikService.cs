using eBotanika.Model.Requests.Uposlenik;

namespace eBotanika.Services
{
    public interface IUposlenikService
    {
        List<Model.Uposlenik> Get(UposlenikSearchRequest request);

        Model.Uposlenik GetById(int id);

        Model.Uposlenik Insert(UposlenikInsertRequest request);

        Model.Uposlenik Update(int id, UposlenikInsertRequest request);

        Model.Uposlenik Authenticiraj(string username, string pass);
    }
}
