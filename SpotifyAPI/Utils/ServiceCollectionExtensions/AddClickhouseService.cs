using Microsoft.Extensions.DependencyInjection;
using Utils.Clickhouse;

namespace Utils.ServiceCollectionExtensions;

public static class AddClickhouseServiceExtension
{
    public static IServiceCollection AddClickhouseService(this IServiceCollection services)
    {
        var clickhouseService = new ClickHouseService(ClickhouseConstants.ConnectionString);
        services.AddSingleton<IClickHouseService>(clickhouseService);
        return services;
    }
}