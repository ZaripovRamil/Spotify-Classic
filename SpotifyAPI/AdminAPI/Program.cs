using AdminAPI.ConfigurationExtensions;
using AdminAPI.Features.Albums.Create.AlbumSavers;
using AdminAPI.ServiceCollectionExtensions;
using AdminAPI.Services;
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
builder.Services.AddScoped<ISaver<Command, string>, DbInfoSaver>();
builder.Services.AddScoped<ISaver<Command, string>, PreviewSaver>();
builder.Services.AddMediatorForAssembly(typeof(Program).Assembly)
    .AddPipelineBehaviors();

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