using External.Redis;
using StackExchange.Redis;
using StaticAPI.ConfigurationExtensions;
using StaticAPI.ServiceCollectionExtensions;
using StaticAPI.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddSingleton<IConnectionMultiplexer>(x =>
{
    var configuration = ConfigurationOptions.Parse("localhost:6379", true);

    return ConnectionMultiplexer.Connect(configuration);
});
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
});
builder.Services.AddSingleton<IRedisCache, RedisCache>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    await app.EnsureTestDataUploadedAsync();
}

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();