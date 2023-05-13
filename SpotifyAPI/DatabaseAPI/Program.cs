using System.Text;
using Database;
using DatabaseServices.Services;
using DatabaseServices.Services.Accessors.Implementations;
using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.DeleteHandlers.Implementations;
using DatabaseServices.Services.DeleteHandlers.Interfaces;
using DatabaseServices.Services.EntityValidators.Implementations;
using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Factories.Implementations;
using DatabaseServices.Services.Factories.Interfaces;
using DatabaseServices.Services.UpdateHandlers.Implementations;
using DatabaseServices.Services.UpdateHandlers.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Spotify"), b => b.MigrationsAssembly("DatabaseAPI")));
builder.Services.AddSingleton<IDtoCreator, DtoCreator>();

builder.Services.AddScoped<IDbUserAccessor, DbUserAccessor>();
builder.Services.AddScoped<IDbAlbumAccessor, DbAlbumAccessor>();
builder.Services.AddScoped<IDbAuthorAccessor, DbAuthorAccessor>();
builder.Services.AddScoped<IDbPlaylistAccessor, DbPlaylistAccessor>();
builder.Services.AddScoped<IDbGenreAccessor, DbGenreAccessor>();
builder.Services.AddScoped<IDbTrackAccessor, DbTrackAccessor>();

builder.Services.AddScoped<IFileIdGenerator, FileIdGenerator>();

builder.Services.AddScoped<IAlbumValidator, AlbumValidator>();
builder.Services.AddScoped<IAuthorValidator, AuthorValidator>();
builder.Services.AddScoped<IGenreValidator, GenreValidator>();
builder.Services.AddScoped<IPlaylistValidator, PlaylistValidator>();
builder.Services.AddScoped<ITrackValidator, TrackValidator>();

builder.Services.AddScoped<IAlbumDeleteHandler, AlbumDeleteHandler>();
builder.Services.AddScoped<IAuthorDeleteHandler, AuthorDeleteHandler>();
builder.Services.AddScoped<ITrackDeleteHandler, TrackDeleteHandler>();

builder.Services.AddScoped<IAuthorUpdateHandler, AuthorUpdateHandler>();
builder.Services.AddScoped<IAlbumUpdateHandler, AlbumUpdateHandler>();
builder.Services.AddScoped<ITrackUpdateHandler, TrackUpdateHandler>();

builder.Services.AddScoped<IAlbumFactory, AlbumFactory>();
builder.Services.AddScoped<IAuthorFactory, AuthorFactory>();
builder.Services.AddScoped<IPlaylistFactory, PlaylistFactory>();
builder.Services.AddScoped<ITrackFactory, TrackFactory>();
builder.Services.AddScoped<IGenreFactory, GenreFactory>();

var solutionConfigurationBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName)
    .AddJsonFile("appsettings.json");
var solutionConfiguration = solutionConfigurationBuilder.Build();

builder.Services.Configure<JwtTokenSettings>(solutionConfiguration.GetSection("JWTTokenSettings"));
builder.Services.Configure<ApplicationHosts>(solutionConfiguration.GetSection("ApplicationHosts"));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opts =>
    {
        opts.RequireHttpsMetadata = false;
        opts.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = solutionConfiguration["JWTTokenSettings:Issuer"],
            ValidAudience = solutionConfiguration["JWTTokenSettings:Audience"],
            IssuerSigningKey =
                new SymmetricSecurityKey(
                    Encoding.ASCII.GetBytes(solutionConfiguration.GetValue<string>("JWTTokenSettings:Key")!))
        };
    });

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer",
        new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Description = "Please insert JWT with Bearer into field",
            Name = "Authorization",
            Type = SecuritySchemeType.ApiKey
        });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
            },
            new string[] { }
        }
    });
});
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(corsPolicyBuilder =>
    {
        corsPolicyBuilder
            .WithOrigins($"http://localhost:{solutionConfiguration.GetSection("ApplicationHosts:UsersFrontend").Value}")
            .AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();