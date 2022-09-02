﻿using AutoMapper;
using eBotanika.Model.Requests.Uposlenik;
using eBotanika.Services.Database;
using System.Security.Cryptography;
using System.Text;

namespace eBotanika.Services
{
    public class UposlenikService : IUposlenikService
    {
        private readonly eBotanikaContext _context;
        private readonly IMapper _mapper;

        public UposlenikService(eBotanikaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Uposlenik Authenticiraj(string username, string pass)
        {
            var user = _context.Uposlenik.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Uposlenik>(user);
                }
            }
            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public List<Model.Uposlenik> Get(UposlenikSearchRequest request)
        {
            var query = _context.Uposlenik.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Uposlenik>>(list);
        }

        public Model.Uposlenik GetById(int id)
        {
            var entity = _context.Uposlenik.Find(id);

            return _mapper.Map<Model.Uposlenik>(entity);
        }

        public Model.Uposlenik Insert(UposlenikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Uposlenik>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Uposlenik.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Uposlenik>(entity);
        }

        public Model.Uposlenik Update(int id, UposlenikInsertRequest request)
        {
            var entity = _context.Uposlenik.Find(id);
            _context.Uposlenik.Attach(entity);
            _context.Uposlenik.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Uposlenik>(entity);
        }
    }
}