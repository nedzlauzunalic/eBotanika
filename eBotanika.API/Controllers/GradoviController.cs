using eBotanika.Model.Requests.Gradovi;
using eBotanika.Services.Gradovi;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GradoviController : ControllerBase
    {
        private readonly IGradoviService _service;

        public GradoviController(IGradoviService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Gradovi>> Get()
        {
            var gradovi = _service.Get();

            return Ok(gradovi);
        }

        [HttpGet("{id}")]
        public Model.Gradovi GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.Gradovi Insert(GradoviInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Gradovi Update(int id, [FromBody] GradoviInsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
