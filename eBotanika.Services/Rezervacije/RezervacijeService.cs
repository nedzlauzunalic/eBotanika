using AutoMapper;
using eBotanika.Model.Requests.Rezervacije;
using eBotanika.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace eBotanika.Services.Rezervacije
{
    public class RezervacijeService : IRezervacijeService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper _mapper;

        public RezervacijeService(eBotanikaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Rezervacije> Get(RezervacijeSearchRequest search)
        {
            var query = _context.Rezervacije.Include(x => x.Korisnik).Include(x => x.Grad).Include(x => x.Svrha).Include(x => x.Biljke).Include(x => x.Ocjena).AsQueryable();

            if (search.SvrhaID != null)
            {
                query = query.Where(x => x.SvrhaID == search.SvrhaID).OrderByDescending(x => x.DatumRezervacije);
            }

            if (search.KorisnikID != null)
            {
                query = query.Where(x => x.KorisnikID == search.KorisnikID).OrderByDescending(x => x.DatumRezervacije);
            }

            if (search.GradID != null)
            {
                query = query.Where(x => x.GradID == search.GradID).OrderByDescending(x => x.DatumRezervacije);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Rezervacije>>(list);
        }

        public Model.Rezervacije Insert(RezervacijeInsertRequest request)
        {
            var result = _mapper.Map<Database.Rezervacije>(request);

            _context.Rezervacije.Add(result);
            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacije>(result);
        }

        public Model.Rezervacije Update(int id, RezervacijeInsertRequest request)
        {
            var result = _context.Rezervacije.Find(id);

            _context.Rezervacije.Attach(result);
            _context.Rezervacije.Update(result);

            _mapper.Map(request, result);

            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacije>(result);
        }

        public Model.Rezervacije GetById(int id)
        {
            var result = _context.Rezervacije.Find(id);

            return _mapper.Map<Model.Rezervacije>(result);
        }

        public List<Model.Rezervacije> GetByKorisnikId(int id)
        {
            var result = _context.Rezervacije.Where(x => x.KorisnikID == id).ToList();

            foreach (var x in result)
            {
                foreach (var o in _context.Ocjena.Where(l => l.KorisnikID == id && l.OcjenaID == x.OcjenaID).ToList())
                {
                    x.OcjenaUsluge = o.OcjenaUsluge;
                }
            }
        
            return _mapper.Map<List<Model.Rezervacije>>(result);
        }

        public Model.Rezervacije Delete(int id)
        {
            var result = _context.Rezervacije.Find(id);

            _context.Rezervacije.Remove(result);
            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacije>(result);
        }
    }
}
