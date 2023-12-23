using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;
using Models.Metadata;
using StackExchange.Redis;

namespace External.Redis;

public interface IRedisCache
{
    public Task<T?> Get<T>(string id) where T : Metadata;
    public Task Set<T>(T value) where T : Metadata;

    public Task Delete<T>(string id) where T : Metadata;
    
    public Task<IEnumerable<T?>> GetAll<T>() where T : Metadata;

    public Task Clear();

    public Task<long> GetCounter(string key);
    public Task IncrementCounter(string key);
    public Task DeleteCounter(string key);


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
    
    public async Task<IEnumerable<T?>> GetAll<T>() where T : Metadata
    {
        var server = _redis.GetServer(_redis.GetEndPoints()[0]);
        var keys = server.Keys().Where(s => s.ToString().EndsWith(":metadata")).Select(s=> s.ToString().Split(':')[0]);
        var values = keys.Select(async key => await Get<T>(key)).ToList();
        var res = await Task.WhenAll(values);
        return res;
    }
    
    public async Task<T?> Get<T>(string id) where T : Metadata
    {
        return JsonSerializer.Deserialize<T>(await _cache.GetStringAsync($"{id}:metadata") ?? string.Empty,
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
    }

    public async Task Set<T>(T value) where T : Metadata
    {
        if (value.FileId is null) throw new InvalidDataException();
        await _cache.SetStringAsync($"{value.FileId}:metadata", JsonSerializer.Serialize(value));
    }
    
    public async Task Delete<T>(string id) where T : Metadata
    {
        await _cache.RemoveAsync($"{id}:metadata");
    }
    
    public async Task Clear()
    {
        var server = _redis.GetServer(_redis.GetEndPoints()[0]);
        await server.FlushAllDatabasesAsync();
    }
    
    public async Task IncrementCounter(string key)
    {
        var redisDb = _redis.GetDatabase();
        await redisDb.StringIncrementAsync($"{key}:counter");
    }
    public async Task<long> GetCounter(string key)
    {
        var redisDb = _redis.GetDatabase();
        var value = await redisDb.StringGetAsync($"{key}:counter");
        return (long)value;
    }
    
    public async Task DeleteCounter(string key)
    {
        await _cache.RemoveAsync($"{key}:counter");
    }
}