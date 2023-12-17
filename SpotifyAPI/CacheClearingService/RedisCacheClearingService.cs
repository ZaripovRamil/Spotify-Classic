using External.Redis;

namespace CacheClearingService;

public class RedisCacheClearingService : IHostedService
{
    private readonly IRedisCache _cache;

    public RedisCacheClearingService(IRedisCache cache)
    {
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