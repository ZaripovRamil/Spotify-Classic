using Database;
using DatabaseServices.Services;
using DatabaseServices.Services.Accessors.Implementations;
using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using SearchAPI.Services;
using Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// EnvFileLoader.Load("local.hostnames");
var parent = Directory.GetParent(Directory.GetCurrentDirectory())!.FullName;
var files = EnvFileLoader.CombinePaths(parent, ".secrets", "local.hostnames", ".kestrel-conf");
foreach (var file in files)
{
    EnvFileLoader.Load(file);
}

builder.Configuration.AddEnvironmentVariables();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(corsPolicyBuilder =>
    {
        corsPolicyBuilder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Spotify")).EnableThreadSafetyChecks());
builder.Services.AddSingleton<IDtoCreator, DtoCreator>();
builder.Services.AddScoped<IDbAlbumAccessor, DbAlbumAccessor>();
builder.Services.AddScoped<IDbAuthorAccessor, DbAuthorAccessor>();
builder.Services.AddScoped<IDbPlaylistAccessor, DbPlaylistAccessor>();
builder.Services.AddScoped<IDbTrackAccessor, DbTrackAccessor>();
builder.Services.AddScoped<IDbUserAccessor, DbUserAccessor>();
builder.Services.AddScoped<ISearchEngine, ShittyEngine>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();