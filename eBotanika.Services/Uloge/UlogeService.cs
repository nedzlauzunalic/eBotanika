using AutoMapper;
using eBotanika.Model.Requests.Uloge;
using eBotanika.Services.Database;

namespace eBotanika.Services.Uloge
{
    public class UlogeService : IUlogeService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper _mapper;

        public UlogeService(eBotanikaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Uloge> Get(UlogeSearchRequest request)
        {
            var query = _context.Uloge.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Uloge>>(list);
        }
    } 
}
