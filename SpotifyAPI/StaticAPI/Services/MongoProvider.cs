using MongoDB.Driver;

namespace StaticAPI.Services;

public class MongoProvider
{
    public IMongoClient _mongoClient;
    
    public MongoProvider(IConfiguration config, IMongoClient _client)
    {
        _mongoClient = _client;
    }
}