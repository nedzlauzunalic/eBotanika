using eBotanika.Model.Requests.Uloge;
using eBotanika.Services.Uloge;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UlogeController : ControllerBase
    {
        private readonly IUlogeService _service;

        public UlogeController(IUlogeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Uloge> Get([FromQuery] UlogeSearchRequest request)
        {
            return _service.Get(request);
        }
    }
}
