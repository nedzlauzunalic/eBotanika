using eBotanika.Model.Requests.Gradovi;

namespace eBotanika.Services.Gradovi
{
    public interface IGradoviService
    {
        List<Model.Gradovi> Get();

        Model.Gradovi GetById(int id);

        Model.Gradovi Insert(GradoviInsertRequest request);

        Model.Gradovi Update(int id, GradoviInsertRequest request);
    }
}
