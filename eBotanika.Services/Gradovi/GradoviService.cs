using AutoMapper;
using eBotanika.Model.Requests.Gradovi;
using eBotanika.Services.Database;

namespace eBotanika.Services.Gradovi
{
    public class GradoviService : IGradoviService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper _mapper;

        public GradoviService(eBotanikaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Gradovi> Get()
        {
            var result = _context.Gradovi.ToList();

            return _mapper.Map<List<Model.Gradovi>>(result);
        }

        public Model.Gradovi GetById(int id)
        {
            var result = _context.Gradovi.Find(id);

            return _mapper.Map<Model.Gradovi>(result);
        }

        public Model.Gradovi Insert(GradoviInsertRequest request)
        {
            var result = _mapper.Map<Database.Gradovi>(request);

            _context.Set<Database.Gradovi>().Add(result);
            _context.SaveChanges();

            return _mapper.Map<Model.Gradovi>(result);
        }

        public Model.Gradovi Update(int id, GradoviInsertRequest request)
        {
            var result = _context.Gradovi.Find(id);

            _context.Gradovi.Attach(result);
            _context.Gradovi.Update(result);
            _mapper.Map(request, result);

            _context.SaveChanges();

            return _mapper.Map<Model.Gradovi>(result);
        }
    }
}
