using Models.Configuration;
using Utils.LocalRun;
using Utils.ServiceCollectionExtensions;

var builder = WebApplication.CreateBuilder(args);

EnvFileLoader.LoadFilesFromParentDirectory("local.secrets", Path.Combine("..", "local.hostnames"), "local.kestrel-conf");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Configuration.AddEnvironmentVariables();

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

app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();