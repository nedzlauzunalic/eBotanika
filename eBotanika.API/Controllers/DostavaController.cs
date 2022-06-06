using eBotanika.Model.Requests.Dostava;
using eBotanika.Services.Dostava;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DostavaController : ControllerBase
    {
        private readonly IDostavaService _service;

        public DostavaController(IDostavaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Dostava> Get([FromQuery] DostavaSearchRequest request)
        {
            return _service.Get(request);
        }

        [Authorize]
        [HttpPost]
        public Model.Dostava Insert(DostavaInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize]
        [HttpPut("{id}")]
        public Model.Dostava Update(int id, [FromBody] DostavaInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Dostava GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public Model.Dostava Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
