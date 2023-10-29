using AuthAPI.Services;
using DatabaseServices.Services;
using DatabaseServices.Services.Repositories.Implementations;
using Models.Configuration;
using Models.OAuth;
using Utils.LocalRun;
using Utils.ServiceCollectionExtensions;
using Utils.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);

EnvFileLoader.LoadFilesFromParentDirectory(".postgres-secrets", "local.secrets", Path.Combine("..", "local.hostnames"), "local.kestrel-conf");

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

builder.Services.AddDbContext(builder.Configuration);

builder.Services.AddIdentity(builder.Environment.IsDevelopment());

builder.Services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();

builder.Services.Configure<JwtTokenSettings>(builder.Configuration.GetSection("JWTTokenSettings"));
builder.Services.Configure<Hosts>(builder.Configuration.GetSection("Hosts"));
builder.Services.Configure<GoogleOptions>(builder.Configuration.GetSection("OAuth:Google"));
builder.Services.AddScoped<IDtoCreator, DtoCreator>();
builder.Services.AddScoped<IStatisticSnapshotCreator, StatisticSnapshotCreator>();

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