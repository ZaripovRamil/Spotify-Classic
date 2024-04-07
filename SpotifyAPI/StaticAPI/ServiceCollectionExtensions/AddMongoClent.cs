using MongoDB.Driver;
using StaticAPI.Configuration;

namespace StaticAPI.ServiceCollectionExtensions;

static class AddMongoClientExtension
{
    public static IServiceCollection AddMongoClient(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MongoConfig>(configuration.GetSection("MongoConfig"));

        var config =  configuration.GetSection("MongoConfig").Get<MongoConfig>();
        if (config is null) throw new ArgumentException("Mongo Config is not provided in the current configuration");
  
        services.AddSingleton<IMongoDatabase>(options => {
            var client = new MongoClient(config.ConnectionString);
            return client.GetDatabase(config.DatabaseName);
        });
        return services;
    }
}