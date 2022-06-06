using AutoMapper;
using eBotanika.Model.Requests.Kategorije;
using eBotanika.Services.Database;

namespace eBotanika.Services.Kategorije
{
    public class KategorijeService : IKategorijeService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper _mapper;

        public KategorijeService(eBotanikaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Model.Kategorija> Get()
        {
            var result = _context.Kategorija.ToList();

            return _mapper.Map<IEnumerable<Model.Kategorija>>(result);
        }

        public Model.Kategorija GetById(int id)
        {
            var result = _context.Kategorija.Find(id);

            return _mapper.Map<Model.Kategorija>(result);
        }

        public Model.Kategorija Insert(KategorijeInsertRequest request)
        {
            var result = _mapper.Map<Database.Kategorija>(request);

            var category = _context.Kategorija.Where(x => x.Naziv == request.Naziv).FirstOrDefault();

            if (category != null)
            {
                throw new Exception("Kategorija vec postoji");
            }

            _context.Set<Database.Kategorija>().Add(result);
            _context.SaveChanges();

            return _mapper.Map<Model.Kategorija>(result);
        }

        public Model.Kategorija Update(int id, KategorijeInsertRequest request)
        {
            var result = _context.Kategorija.Find(id);

            _context.Kategorija.Attach(result);
            _context.Kategorija.Update(result);

            _mapper.Map(request, result);

            _context.SaveChanges();

            return _mapper.Map<Model.Kategorija>(result);
        }
    }
}
