using eBotanika.Model.Requests.Ocjena;
using eBotanika.Services.Ocjena;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OcjenaController : ControllerBase
    {
        private readonly IOcjenaService _service;

        public OcjenaController(IOcjenaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Ocjena> Get([FromQuery] OcjenaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Ocjena Insert(OcjenaInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Ocjena Update(int id, [FromBody] OcjenaInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpDelete("{id}")]
        public Model.Ocjena Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
