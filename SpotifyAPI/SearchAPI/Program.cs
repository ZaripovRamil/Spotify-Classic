using DatabaseServices.Services;
using DatabaseServices.Services.Repositories.Implementations;
using SearchAPI.Services;
using Utils.LocalRun;
using Utils.ServiceCollectionExtensions;
using Utils.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);

EnvFileLoader.LoadFilesFromParentDirectory(".postgres-secrets", "local.secrets", Path.Combine("..", "local.hostnames"), "local.kestrel-conf");

builder.Configuration.AddEnvironmentVariables();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerWithAuthorization();
builder.Services.AddAllCors();

builder.Services.AddDbContext(builder.Configuration);

builder.Services.AddSingleton<IDtoCreator, DtoCreator>();
builder.Services.AddScoped<IAlbumRepository, AlbumRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IPlaylistRepository, PlaylistRepository>();
builder.Services.AddScoped<ITrackRepository, TrackRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISearchEngine, ShittyEngine>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();