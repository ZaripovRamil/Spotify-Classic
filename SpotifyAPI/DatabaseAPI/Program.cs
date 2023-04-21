using Microsoft.EntityFrameworkCore;
using Database;
using Database.Services;
using Database.Services.Accessors.Implementations;
using Database.Services.Accessors.Interfaces;
using Database.Services.EntityValidators.Implementations;
using Database.Services.EntityValidators.Interfaces;
using Database.Services.Factories.Implementations;
using Database.Services.Factories.Interfaces;

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