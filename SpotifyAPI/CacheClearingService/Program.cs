using CacheClearingService;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services => { services.AddHostedService<RedisCacheClearingService>(); })
    .Build();

host.Run();