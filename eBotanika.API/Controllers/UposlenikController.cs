using eBotanika.Model.Requests.Uposlenik;
using eBotanika.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class UposlenikController : ControllerBase
    {
        private readonly IUposlenikService _service;

        public UposlenikController(IUposlenikService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Uposlenik> Get([FromQuery] UposlenikSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Uposlenik Insert(UposlenikInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Uposlenik Update(int id, [FromBody] UposlenikInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Uposlenik GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
