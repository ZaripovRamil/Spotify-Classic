using Models.Configuration;
using StaticAPI.Services;
using StaticAPI.Startup;
using Utils.ServiceCollectionExtensions;

var builder = WebApplication.CreateBuilder(args);

LocalEnvFiles.Load(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<IFileProvider, FileProvider>();
builder.Services.AddTransient<IHlsConverter, HlsConverter>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();