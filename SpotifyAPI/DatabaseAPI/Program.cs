using Microsoft.EntityFrameworkCore;
using Database;
using DatabaseServices;
using DatabaseServices.Services;
using DatabaseServices.Services.Accessors.Implementations;
using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.EntityValidators.Implementations;
using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Factories.Implementations;
using DatabaseServices.Services.Factories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Spotify")).EnableThreadSafetyChecks());
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
builder.Services.AddScoped<IAlbumFactory, AlbumFactory>();
builder.Services.AddScoped<IAuthorFactory, AuthorFactory>();
builder.Services.AddScoped<IPlaylistFactory, PlaylistFactory>();
builder.Services.AddScoped<ITrackFactory, TrackFactory>();
builder.Services.AddScoped<IGenreFactory, GenreFactory>();
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