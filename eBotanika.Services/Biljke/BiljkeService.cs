using AutoMapper;
using eBotanika.Model.Requests.Biljke;
using eBotanika.Services.Database;
using System.Linq;

namespace eBotanika.Services.Biljke
{
    public class BiljkeService : IBiljkeService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper _mapper;

        public BiljkeService(eBotanikaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Biljke> Get(BiljkeSearchRequest request)
        {
            var query = _context.Set<Database.Biljke>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Biljke>>(list);
        }

        public Model.Biljke GetById(int id)
        {
            var result = _context.Biljke.Find(id);

            return _mapper.Map<Model.Biljke>(result);
        }

        public Model.Biljke Insert(BiljkeInsertRequest request)
        {
            var result = _mapper.Map<Database.Biljke>(request);

            _context.Set<Database.Biljke>().Add(result);
            _context.SaveChanges();

            return _mapper.Map<Model.Biljke>(result);
        }

        public Model.Biljke Update(int id, BiljkeInsertRequest request)
        {
            var result = _context.Biljke.Find(id);

            _context.Biljke.Attach(result);
            _context.Biljke.Update(result);

            _mapper.Map(request, result);

            _context.SaveChanges();

            return _mapper.Map<Model.Biljke>(result);
        }

        public Model.Biljke Delete(int id)
        {
            var result = _context.Biljke.Find(id);

            _context.Biljke.Remove(result);
            _context.SaveChanges();

            return _mapper.Map<Model.Biljke>(result);
        }
    }
}

