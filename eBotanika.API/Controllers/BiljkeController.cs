using eBotanika.Model.Requests.Biljke;
using eBotanika.Services.Biljke;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BiljkeController : ControllerBase
    {
        private readonly IBiljkeService _service;

        public BiljkeController(IBiljkeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Biljke> Get([FromQuery] BiljkeSearchRequest request)
        {
            return _service.Get(request);
        }

        [Authorize]
        [HttpPost]
        public Model.Biljke Insert(BiljkeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize]
        [HttpPut("{id}")]
        public Model.Biljke Update(int id, [FromBody] BiljkeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Biljke GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public Model.Biljke Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
