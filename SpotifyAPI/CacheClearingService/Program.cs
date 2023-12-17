using CacheClearingService;
using External.Redis;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<RedisCacheClearingService>();
        services.AddSingleton<IRedisCache, RedisCache>();
    })
    .Build();

host.Run();