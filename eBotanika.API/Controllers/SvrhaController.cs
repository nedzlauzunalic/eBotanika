using eBotanika.Model.Requests.Svrha;
using eBotanika.Services.Svrha;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SvrhaController : ControllerBase
    {
        private readonly ISvrhaService _service;

        public SvrhaController(ISvrhaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Svrha> Get([FromQuery] SvrhaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Svrha GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
