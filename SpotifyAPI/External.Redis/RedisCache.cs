using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;
using Models.Metadata;
using StackExchange.Redis;

namespace External.Redis;

public interface IRedisCache
{
    public Task<T?> Get<T>(string id) where T : Metadata;
    public Task Set<T>(T value) where T : Metadata;

    public Task Clear();
}

public class RedisCache : IRedisCache
{
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _redis;

    public RedisCache(IDistributedCache cache, IConnectionMultiplexer redis)
    {
        _cache = cache;
        _redis = redis;
    }

    public async Task<T?> Get<T>(string id) where T : Metadata
    {
        return JsonSerializer.Deserialize<T>(await _cache.GetStringAsync(id) ?? string.Empty,
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
    }

    public async Task Set<T>(T value) where T : Metadata
    {
        await _cache.SetStringAsync(value.FileId, JsonSerializer.Serialize(value));
    }

    public async Task Clear()
    {
        var server = _redis.GetServer(_redis.GetEndPoints()[0]);
        await server.FlushAllDatabasesAsync();
    }
}