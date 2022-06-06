using AutoMapper;
using eBotanika.Model.Requests.Placanje;
using eBotanika.Services.Database;

namespace eBotanika.Services.Placanje
{
    public class PlacanjeService : IPlacanjeService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper _mapper;

        public PlacanjeService(eBotanikaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Placanje> Get(PlacanjeSearchRequest search)
        {
            var query = _context.Set<Database.Placanje>().AsQueryable();

            if (search.BrojKartice != null)
            {
                query = query.Where(i => i.BrojKartice == search.BrojKartice);
            }

            if (search.KorisnikId != null)
            {
                query = query.Where(i => i.KorisnikId == search.KorisnikId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Placanje>>(list);
        }

        public Model.Placanje Insert(PlacanjeInsertRequest request)
        {
            var entity = _mapper.Map<Database.Placanje>(request);

            _context.Placanje.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Placanje>(entity);
        }

        public Model.Placanje Delete(int id)
        {
            var result = _context.Placanje.Find(id);

            _context.Placanje.Remove(result);
            _context.SaveChanges();

            return _mapper.Map<Model.Placanje>(result);
        }
    }
}
