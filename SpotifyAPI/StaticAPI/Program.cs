using Models.Configuration;
using StaticAPI.ConfigurationExtensions;
using StaticAPI.Services;
using Utils.ServiceCollectionExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<IFileProvider, FileProvider>();
builder.Services.AddTransient<IHlsConverter, HlsConverter>();

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddMediatorForAssembly(typeof(Program).Assembly);
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