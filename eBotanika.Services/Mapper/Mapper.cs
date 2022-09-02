using AutoMapper;
using eBotanika.Services.Database;

namespace eBotanika.Services.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.Korisnik, Model.Requests.Korisnik.KorisnikInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Requests.Korisnik.KorisnikSearchRequest>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Requests.Korisnik.KorisnikUpdateRequest>().ReverseMap();

            CreateMap<Uposlenik, Model.Uposlenik>();
            CreateMap<Uposlenik, Model.Requests.Uposlenik.UposlenikInsertRequest>().ReverseMap();
            CreateMap<Uposlenik, Model.Requests.Uposlenik.UposlenikSearchRequest>().ReverseMap();
            CreateMap<Uposlenik, Model.Requests.Uposlenik.UposlenikUpdateRequest>().ReverseMap();

            CreateMap<Database.Rezervacije, Model.Rezervacije>();
            CreateMap<Database.Rezervacije, Model.Requests.Rezervacije.RezervacijeInsertRequest>().ReverseMap();
            CreateMap<Database.Rezervacije, Model.Requests.Rezervacije.RezervacijeSearchRequest>().ReverseMap();

            CreateMap<Database.Placanje, Model.Placanje>();
            CreateMap<Database.Placanje, Model.Requests.Placanje.PlacanjeInsertRequest>().ReverseMap();
            CreateMap<Database.Placanje, Model.Requests.Placanje.PlacanjeSearchRequest>().ReverseMap();

            CreateMap<Kategorija, Model.Kategorija>();
            CreateMap<Kategorija, Model.Requests.Kategorije.KategorijeInsertRequest>().ReverseMap();

            CreateMap<Database.Dostava, Model.Dostava>();
            CreateMap<Database.Dostava, Model.Requests.Dostava.DostavaInsertRequest>().ReverseMap();
            CreateMap<Database.Dostava, Model.Requests.Dostava.DostavaSearchRequest>().ReverseMap();

            CreateMap<Database.Biljke, Model.Biljke>();
            CreateMap<Database.Biljke, Model.Requests.Biljke.BiljkeInsertRequest>().ReverseMap();
            CreateMap<Database.Biljke, Model.Requests.Biljke.BiljkeSearchRequest>().ReverseMap();
            CreateMap<Database.Biljke, Model.Requests.Biljke.BiljkeUpdateRequest>().ReverseMap();

            CreateMap<Database.Ocjena, Model.Ocjena>();
            CreateMap<Database.Ocjena, Model.Requests.Ocjena.OcjenaInsertRequest>().ReverseMap();
            CreateMap<Database.Ocjena, Model.Requests.Ocjena.OcjenaSearchRequest>().ReverseMap();

            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Database.Uloge, Model.Requests.Uloge.UlogeSearchRequest>().ReverseMap();

            CreateMap<Database.Svrha, Model.Svrha>();
            CreateMap<Database.Svrha, Model.Requests.Svrha.SvrhaSearchRequest>().ReverseMap();

            CreateMap<Database.Gradovi, Model.Gradovi>();
            CreateMap<Database.Gradovi, Model.Requests.Gradovi.GradoviInsertRequest>().ReverseMap();
        }
    }
}
