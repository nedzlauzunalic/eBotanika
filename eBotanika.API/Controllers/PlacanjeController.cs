using eBotanika.Model.Requests.Placanje;
using eBotanika.Services.Placanje;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlacanjeController : ControllerBase
    {
        private readonly IPlacanjeService _service;

        public PlacanjeController(IPlacanjeService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public List<Model.Placanje> Get([FromQuery] PlacanjeSearchRequest request)
        {
            return _service.Get(request);
        }

        [AllowAnonymous]
        [HttpPost]
        public Model.Placanje Insert(PlacanjeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpDelete("{id}")]
        public Model.Placanje Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
