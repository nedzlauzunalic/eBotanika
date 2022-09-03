using AutoMapper;
using eBotanika.Model.Requests.Ocjena;
using eBotanika.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace eBotanika.Services.Ocjena
{
    public class OcjenaService : IOcjenaService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper _mapper;

        public OcjenaService(eBotanikaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Ocjena> Get(OcjenaSearchRequest search)
        {
            var query = _context.Set<Database.Ocjena>().Include(x => x.Biljke).AsQueryable();

            if (search.BiljkeID > 0)
            {
                query = query.Where(x => x.Biljke.BiljkeID == search.BiljkeID).OrderBy(x => x.KorisnikID);
            }

            if (search.KorisnikID > 0)
            {
                query = query.Where(x => x.KorisnikID == search.KorisnikID).OrderBy(x => x.KorisnikID);
            }

            var list = query.ToList();

            List<Model.Ocjena> ocjene = _mapper.Map<List<Model.Ocjena>>(list);

            foreach (var x in ocjene)
            {
                var ocjena = _context.Ocjena.Include(i => i.Korisnik.Ocjena).Where(k => k.OcjenaID == x.OcjenaID).FirstOrDefault();
                x.KorisnikID = ocjena.KorisnikID;
                x.BiljkeID = ocjena.BiljkeID;
            }
            return ocjene;
        }

        public Model.Ocjena Insert(OcjenaInsertRequest request)
        {
            var result = _mapper.Map<Database.Ocjena>(request);

            _context.Set<Database.Ocjena>().Add(result);
            _context.SaveChanges();

            return _mapper.Map<Model.Ocjena>(result);
        }

        public Model.Ocjena Update(int id, OcjenaInsertRequest request)
        {
            var result = _context.Ocjena.Find(id);

            _context.Ocjena.Attach(result);
            _context.Ocjena.Update(result);

            _mapper.Map(request, result);

            _context.SaveChanges();

            return _mapper.Map<Model.Ocjena>(result);
        }

        public Model.Ocjena Delete(int id)
        {
            var result = _context.Ocjena.Find(id);

            _context.Ocjena.Remove(result);
            _context.SaveChanges();

            return _mapper.Map<Model.Ocjena>(result);
        }

        public List<Model.Ocjena> GetByKorisnikId(int korisnikid)
        {
            var result = _context.Ocjena.Where(x => x.KorisnikID == korisnikid).ToList();

            return _mapper.Map<List<Model.Ocjena>>(result);
        }

        public Model.Ocjena GetById(int id)
        { 
            var entity = _context.Ocjena.Find(id);
            return _mapper.Map<Model.Ocjena>(entity);
        }
    }
}
