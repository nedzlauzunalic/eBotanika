using eBotanika.Services.UposlenikUloge;
using Microsoft.AspNetCore.Mvc;

namespace eBotanika.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UposlenikUlogeController : ControllerBase
    {
        private readonly IUposlenikUlogeService _service;

        public UposlenikUlogeController(IUposlenikUlogeService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public Model.UposlenikUloge GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
