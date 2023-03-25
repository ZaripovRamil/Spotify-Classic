using Microsoft.EntityFrameworkCore;
using Database;
using Database.Services.Accessors;
using Database.Services.Factories;
using Models.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IHashingService, HashingService>();
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("Spotify")));
builder.Services.AddScoped<IDbUserAccessor, DbUserAccessor>();
builder.Services.AddScoped<IDbPlaylistAccessor, DbPlaylistAccessor>();
builder.Services.AddScoped<IDbGenreAccessor, DbGenreAccessor>();
builder.Services.AddScoped<IDbTrackAccessor, DbTrackAccessor>();
builder.Services.AddScoped<IPlaylistFactory, PlaylistFactory>();
builder.Services.AddScoped<ITrackFactory, TrackFactory>();
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