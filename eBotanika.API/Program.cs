using eBotanika.API.Security;
using eBotanika.Services;
using eBotanika.Services.Biljke;
using eBotanika.Services.Database;
using eBotanika.Services.Dostava;
using eBotanika.Services.Gradovi;
using eBotanika.Services.Kategorije;
using eBotanika.Services.Korisnik;
using eBotanika.Services.Ocjena;
using eBotanika.Services.Placanje;
using eBotanika.Services.Rezervacije;
using eBotanika.Services.Svrha;
using eBotanika.Services.Uloge;
using eBotanika.WebAPI.Filters;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(x =>
{
    x.Filters.Add<ErrorFilter>();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
            },
            new string[]{}
        }
    });
});

builder.Services.AddTransient<IBiljkeService, BiljkeService>();
builder.Services.AddTransient<IGradoviService, GradoviService>();
builder.Services.AddTransient<IKategorijeService, KategorijeService>();
builder.Services.AddTransient<IKorisnikService, KorisnikService>();
builder.Services.AddTransient<IOcjenaService, OcjenaService>();
builder.Services.AddTransient<IUposlenikService, UposlenikService>();
builder.Services.AddTransient<IUlogeService, UlogeService>();
builder.Services.AddTransient<ISvrhaService, SvrhaService>();
builder.Services.AddTransient<IDostavaService, DostavaService>();
builder.Services.AddTransient<IPlacanjeService, PlacanjeService>();
builder.Services.AddTransient<IRezervacijeService, RezervacijeService>();

builder.Services.AddAutoMapper(typeof(IKorisnikService));

builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<eBotanikaContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<eBotanikaContext>();
    //dataContext.Database.Migrate();
}

app.Run();
