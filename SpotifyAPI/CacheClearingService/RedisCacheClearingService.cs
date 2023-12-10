using StackExchange.Redis;

namespace CacheClearingService;

public class RedisCacheClearingService : IHostedService
{
    private readonly IConnectionMultiplexer _redis;

    public RedisCacheClearingService(IConnectionMultiplexer redis)
    {
        _redis = redis;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        ClearCache();
        Thread.Sleep(TimeSpan.FromDays(1));
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private void ClearCache()
    {
        var server = _redis.GetServer(_redis.GetEndPoints()[0]);
        server.FlushAllDatabases();
    }
}