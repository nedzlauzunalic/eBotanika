using AutoMapper;
using eBotanika.Services.Database;

namespace eBotanika.Services.UposlenikUloge
{
    public class UposlenikUlogeService : IUposlenikUlogeService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper  _mapper;
        public UposlenikUlogeService(eBotanikaContext context, IMapper mapper)
        {
            _context = context;
            _mapper  = mapper;
        }

        public Model.UposlenikUloge GetById(int id)
        {
            var entity = _context.UposlenikUloge.Find(id);

            return _mapper.Map<Model.UposlenikUloge>(entity);
        }
    }
}


