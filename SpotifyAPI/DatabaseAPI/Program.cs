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
using Microsoft.EntityFrameworkCore;
using Models.Configuration;
using Utils.LocalRunDependencies;
using Utils.ServiceCollectionExtensions;

var builder = WebApplication.CreateBuilder(args);

EnvFileLoader.LoadFilesFromParentDirectory(".postgres-secrets", "local.secrets", "local.hostnames", "local.kestrel-conf");

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext(builder.Configuration);
builder.Services.AddSingleton<IDtoCreator, DtoCreator>();

builder.Services.AddScoped<IDbUserAccessor, DbUserAccessor>();
builder.Services.AddScoped<IDbAlbumAccessor, DbAlbumAccessor>();
builder.Services.AddScoped<IDbAuthorAccessor, DbAuthorAccessor>();
builder.Services.AddScoped<IDbPlaylistAccessor, DbPlaylistAccessor>();
builder.Services.AddScoped<IDbGenreAccessor, DbGenreAccessor>();
builder.Services.AddScoped<IDbTrackAccessor, DbTrackAccessor>();
builder.Services.AddScoped<IDbSupportChatHistoryAccessor, DbSupportChatHistoryAccessor>();

builder.Services.AddScoped<IFileIdGenerator, FileIdGenerator>();

builder.Services.AddScoped<IAlbumValidator, AlbumValidator>();
builder.Services.AddScoped<IAuthorValidator, AuthorValidator>();
builder.Services.AddScoped<IGenreValidator, GenreValidator>();
builder.Services.AddScoped<IPlaylistValidator, PlaylistValidator>();
builder.Services.AddScoped<ITrackValidator, TrackValidator>();

builder.Services.AddScoped<IAlbumDeleteHandler, AlbumDeleteHandler>();
builder.Services.AddScoped<IAuthorDeleteHandler, AuthorDeleteHandler>();
builder.Services.AddScoped<ITrackDeleteHandler, TrackDeleteHandler>();
builder.Services.AddScoped<IPlaylistDeleteHandler, PlaylistDeleteHandler>();

builder.Services.AddScoped<IAuthorUpdateHandler, AuthorUpdateHandler>();
builder.Services.AddScoped<IAlbumUpdateHandler, AlbumUpdateHandler>();
builder.Services.AddScoped<ITrackUpdateHandler, TrackUpdateHandler>();
builder.Services.AddScoped<IPlaylistUpdateHandler, PlaylistUpdateHandler>();

builder.Services.AddScoped<IAlbumFactory, AlbumFactory>();
builder.Services.AddScoped<IAuthorFactory, AuthorFactory>();
builder.Services.AddScoped<IPlaylistFactory, PlaylistFactory>();
builder.Services.AddScoped<ITrackFactory, TrackFactory>();
builder.Services.AddScoped<IGenreFactory, GenreFactory>();

builder.Services.Configure<JwtTokenSettings>(builder.Configuration.GetSection("JWTTokenSettings"));
builder.Services.Configure<Hosts>(builder.Configuration.GetSection("Hosts"));

builder.Services.AddJwtAuthorization(builder.Configuration);
builder.Services.AddSwaggerWithAuthorization();
builder.Services.AddAllCors();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

LocalDependencies.EnsureStarted(builder.Configuration);

app.Run();

LocalDependencies.EnsureExited();