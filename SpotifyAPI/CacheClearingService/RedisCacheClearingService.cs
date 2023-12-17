using External.Redis;
using StackExchange.Redis;

namespace CacheClearingService;

public class RedisCacheClearingService : IHostedService
{
    private readonly IConnectionMultiplexer _redis;
    private readonly IRedisCache _cache;

    public RedisCacheClearingService(IConnectionMultiplexer redis, IRedisCache cache)
    {
        _redis = redis;
        _cache = cache;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await ClearCache();
        Thread.Sleep(TimeSpan.FromDays(1));
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private async Task ClearCache()
    {
        await _cache.Clear();
    }
}