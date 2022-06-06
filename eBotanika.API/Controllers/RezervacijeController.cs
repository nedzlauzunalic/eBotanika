using eBotanika.Model.Requests.Rezervacije;
using eBotanika.Services.Rezervacije;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RezervacijeController : ControllerBase
    {
        private readonly IRezervacijeService _service;

        public RezervacijeController(IRezervacijeService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public List<Model.Rezervacije> Get([FromQuery] RezervacijeSearchRequest request)
        {
            return _service.Get(request);
        }

        [AllowAnonymous]
        [HttpPost]
        public Model.Rezervacije Insert(RezervacijeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [AllowAnonymous]
        [HttpPut("{id}")]
        public Model.Rezervacije Update(int id, [FromBody] RezervacijeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Rezervacije GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpDelete("{id}")]
        public Model.Rezervacije Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
