using AutoMapper;
using eBotanika.Services.Database;

namespace eBotanika.Services.UposlenikUloge
{
    public class UposlenikUlogeService : BaseService<Model.UposlenikUloge, object, Database.UposlenikUloge>
    {
        public UposlenikUlogeService(eBotanikaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.UposlenikUloge> Get(object search)
        {
            var list = _context.UposlenikUloge.ToList();

            return _mapper.Map<List<Model.UposlenikUloge>>(list);
        }
    }
}


