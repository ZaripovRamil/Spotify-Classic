using DatabaseServices;
using SearchAPI.ConfigurationExtensions;
using SearchAPI.Services;
using Utils.ServiceCollectionExtensions;
using Utils.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerWithAuthorization();
builder.Services.AddAllCors();

builder.Services.AddRepositories(builder.Configuration);
builder.Services.AddSingleton<IDtoCreator, DtoCreator>();
builder.Services.AddScoped<ISearchEngine, ShittyEngine>();

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