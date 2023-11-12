using AdminAPI.ConfigurationExtensions;
using AdminAPI.Features.Albums.Create.AlbumSaver;
using AdminAPI.Features.Authors;
using AdminAPI.Features.Tracks;
using AdminAPI.ServiceCollectionExtensions;
using AdminAPI.Services;
using DatabaseServices.EntityValidators.Implementations;
using DatabaseServices.EntityValidators.Interfaces;
using Models.Configuration;
using Utils.ServiceCollectionExtensions;
using Utils.WebApplicationExtensions;
using FluentValidation;
using Command = AdminAPI.Features.Albums.Create.Command;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();

builder.Services.Configure<JwtTokenSettings>(builder.Configuration.GetSection("JWTTokenSettings"));
builder.Services.Configure<Hosts>(builder.Configuration.GetSection("Hosts"));

builder.Services.AddHttpClients(builder.Configuration);
builder.Services.AddRepositories(builder.Configuration);
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);
builder.Services.AddScoped<ISaver<Command>, AlbumDbSaver>();
builder.Services.AddScoped<ISaver<Command>, AlbumPreviewSaver>();
builder.Services.AddMediatorForAssembly(typeof(Program).Assembly)
    .AddPipelineBehaviors();

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