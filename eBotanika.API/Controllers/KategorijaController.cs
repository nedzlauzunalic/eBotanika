using eBotanika.Model.Requests.Kategorije;
using eBotanika.Services.Kategorije;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class KategorijaController : ControllerBase
    {
        private readonly IKategorijeService _service;

        public KategorijaController(IKategorijeService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerator<Model.Kategorija>> Get()
        {
            var kategorije = _service.Get();

            return Ok(kategorije);
        }

        [HttpGet("{id}")]
        public Model.Kategorija GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.Kategorija Insert(KategorijeInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
