using DatabaseServices.Services;
using SearchAPI.ConfigurationExtensions;
using Utils.ServiceCollectionExtensions;
using Utils.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerWithAuthorization();
builder.Services.AddAllCors();

builder.Services.AddMediatorForAssembly(typeof(Program).Assembly);
builder.Services.AddRepositories(builder.Configuration);
builder.Services.AddSingleton<IDtoCreator, DtoCreator>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();