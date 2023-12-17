using External.Redis;
using StackExchange.Redis;

namespace StaticAPI.Features.Track.UploadTrack;

public class RedisClearingService : BackgroundService
{
    private readonly TimeSpan _idlePeriod = TimeSpan.FromDays(1);
    private readonly IConnectionMultiplexer _redis;
    private readonly IRedisCache _cache;

    public RedisClearingService(IConnectionMultiplexer redis, IRedisCache cache)
    {
        _redis = redis;
        _cache = cache;
    }

    /*public Task StartAsync(CancellationToken cancellationToken)
    {
        
        Thread.Sleep(TimeSpan.FromDays(1));
        return Task.CompletedTask;
    }*/

    /*public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }*/

    /*private void ClearCache()
    {
        var server = _redis.GetServer(_redis.GetEndPoints()[0]);
        server.FlushAllDatabases();
    }*/
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            
            //ClearCache();
            await Task.Delay(_idlePeriod, stoppingToken);
        }
    }
}