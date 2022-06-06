using AutoMapper;
using eBotanika.Model.Requests.Svrha;
using eBotanika.Services.Database;

namespace eBotanika.Services.Svrha
{
    public class SvrhaService : ISvrhaService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper _mapper;

        public SvrhaService(eBotanikaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Svrha> Get(SvrhaSearchRequest request)
        {
            var query = _context.Svrha.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Svrha>>(list);
        }

        public Model.Svrha GetById(int id)
        {
            var entity = _context.Svrha.Find(id);

            return _mapper.Map<Model.Svrha>(entity);
        }
    }
}
