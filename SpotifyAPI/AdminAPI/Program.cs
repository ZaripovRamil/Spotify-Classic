using AdminAPI.ConfigurationExtensions;
using DatabaseServices;
using DatabaseServices.CommandHandlers.CreateHandlers;
using DatabaseServices.CommandHandlers.DeleteHandlers;
using DatabaseServices.CommandHandlers.UpdateHandlers;
using DatabaseServices.EntityValidators.Implementations;
using DatabaseServices.EntityValidators.Interfaces;
using Models.Configuration;
using Utils.ServiceCollectionExtensions;
using Utils.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();

builder.Services.Configure<JwtTokenSettings>(builder.Configuration.GetSection("JWTTokenSettings"));
builder.Services.Configure<Hosts>(builder.Configuration.GetSection("Hosts"));

builder.Services.AddRepositories(builder.Configuration);

builder.Services.AddScoped<IFileIdGenerator, FileIdGenerator>();

builder.Services.AddScoped<IAlbumCreateHandler, AlbumCreateHandler>();
builder.Services.AddScoped<IAlbumUpdateHandler, AlbumUpdateHandler>();
builder.Services.AddScoped<IAlbumDeleteHandler, AlbumDeleteHandler>();
builder.Services.AddScoped<IAlbumValidator, AlbumValidator>();

builder.Services.AddScoped<IAuthorCreateHandler, AuthorCreateHandler>();
builder.Services.AddScoped<IAuthorUpdateHandler, AuthorUpdateHandler>();
builder.Services.AddScoped<IAuthorDeleteHandler, AuthorDeleteHandler>();
builder.Services.AddScoped<IAuthorValidator, AuthorValidator>();

builder.Services.AddScoped<ITrackCreateHandler, TrackCreateHandler>();
builder.Services.AddScoped<ITrackUpdateHandler, TrackUpdateHandler>();
builder.Services.AddScoped<ITrackDeleteHandler, TrackDeleteHandler>();
builder.Services.AddScoped<ITrackValidator, TrackValidator>();

builder.Services.AddJwtAuthorization(builder.Configuration);
builder.Services.AddSwaggerWithAuthorization();
builder.Services.AddAllCors();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();