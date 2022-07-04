using AutoMapper;
using eBotanika.Model.Requests.Dostava;
using eBotanika.Services.Database;

namespace eBotanika.Services.Dostava
{
    public class DostavaService : IDostavaService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper _mapper;

        public DostavaService(eBotanikaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Dostava> Get(DostavaSearchRequest request)
        {
            var query = _context.Set<Database.Dostava>().AsQueryable();

            var list = query.ToList();

            return _mapper.Map<List<Model.Dostava>>(list);
        }

        public Model.Dostava Insert(DostavaInsertRequest request)
        {
            var result = _mapper.Map<Database.Dostava>(request);

            _context.Set<Database.Dostava>().Add(result);
            _context.SaveChanges();

            return _mapper.Map<Model.Dostava>(result);
        }

        public Model.Dostava Update(int id, DostavaInsertRequest request)
        {
            var result = _context.Dostava.Find(id);

            _context.Dostava.Attach(result);
            _context.Dostava.Update(result);

            _mapper.Map(request, result);

            _context.SaveChanges();

            return _mapper.Map<Model.Dostava>(result);
        }

        public List<Model.Dostava> GetById(int id)
        {
            var result = _context.Dostava.Where(x => x.KorisnikID == id).ToList();

            return _mapper.Map<List<Model.Dostava>>(result);
        }

        public Model.Dostava Delete(int id)
        {
            var result = _context.Dostava.Find(id);

            _context.Dostava.Remove(result);
            _context.SaveChanges();

            return _mapper.Map<Model.Dostava>(result);
        }
    }
}
