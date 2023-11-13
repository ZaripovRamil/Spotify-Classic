using AuthAPI.ConfigurationExtensions;
using AuthAPI.Features.GetStatistics;
using AuthAPI.Features.SignIn;
using DatabaseServices;
using Models.Configuration;
using Models.OAuth;
using Utils.ServiceCollectionExtensions;
using Utils.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

builder.Services.AddIdentity(builder.Environment.IsDevelopment());
builder.Services.AddRepositories(builder.Configuration);

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