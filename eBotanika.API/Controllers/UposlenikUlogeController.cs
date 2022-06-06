using eBotanika.Model;
using eBotanika.Services;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UposlenikUlogeController : BaseController<Model.UposlenikUloge, object>
    {
        public UposlenikUlogeController(IService<UposlenikUloge, object> service) : base(service)
        {

        }
    }
}
