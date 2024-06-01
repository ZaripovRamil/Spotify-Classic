using PlayerAPI.ConfigurationExtensions;
using PlayerAPI.ServiceCollectionExtensions;
using Utils.Clickhouse;
using Utils.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IClickHouseService>(
    new ClickHouseService("Host=localhost;Port=8123;Database=default;User=default;Password=;"));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
    app.CreateRabbitMqQueues();
}

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();