using AutoMapper;
using eBotanika.Model.Requests.Biljke;
using eBotanika.Services.Database;

using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;

namespace eBotanika.Services.Biljke
{
    public class BiljkeService : IBiljkeService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper          _mapper;
        static           MLContext        mlContext = null;
        static           object           isLocked  = new object();
        static           ITransformer     model     = null;

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

        public List<Model.Biljke> Recommend(int id)
        {
            lock (isLocked)
            {
                if (mlContext == null)
                {
                    mlContext = new MLContext();

                    var data = new List<ProductEntry>();

                    var distinctItemId = _context.Rezervacije.Select(y => y.BiljkeID).ToList();

                        distinctItemId.ForEach(y =>
                        {
                                var relatedItems = _context.Rezervacije.Where(z => z.BiljkeID != y);

                                foreach (var z in relatedItems)
                                {
                                    data.Add(new ProductEntry()
                                    {
                                        ProductID           = (uint)y,
                                        CoPurchaseProductID = (uint)z.BiljkeID,
                                    });
                                }
                        });

                        var traindata = mlContext.Data.LoadFromEnumerable(data);

                    MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                    options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
                    options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
                    options.LabelColumnName = "Label";
                    options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                    options.Alpha = 0.01;
                    options.Lambda = 0.025;
                    options.NumberOfIterations = 100;
                    options.C                  = 0.00001;

                    var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

                    model = est.Fit(traindata);
                }
            }

            List<Database.Biljke> allItems = new List<Database.Biljke>();

            for(int i = 0; i< 10000; i++)
            {
                var tmp = _context.Biljke.Where(x => x.BiljkeID != id);
                allItems.AddRange(tmp);
            }

            var predictionResult = new List<Tuple<Database.Biljke, float>>();

            foreach(var item in allItems)
            {
              var predictionEngine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model); 
              var prediction = predictionEngine.Predict(new ProductEntry()
              {
                ProductID           = (uint)id,
                CoPurchaseProductID = (uint)item.BiljkeID
              });

              predictionResult.Add(new Tuple<Database.Biljke, float>(item, prediction.Score));
            }

            var finalResult = predictionResult.OrderByDescending(x => x.Item2)
                                          .Select(x => x.Item1).Take(1);

             return _mapper.Map<List<Model.Biljke>>(finalResult);
        }

        public class Copurchase_prediction
        {
            public float Score { get; set; }
        }

        public class ProductEntry
        {
            [KeyType(count: 10)]
            public uint ProductID { get; set; }

            [KeyType(count: 10)]
            public uint CoPurchaseProductID { get; set; }

            public float Label { get; set; }
        }
    }
}

