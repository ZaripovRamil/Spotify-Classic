using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Utils.Clickhouse;

namespace Utils.WebApplicationExtensions;

public static class CreateClickhouseTableExtension
{
    public static async Task CreateClickhouseTableAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var clickhouseService = scope.ServiceProvider.GetRequiredService<IClickHouseService>();
        await clickhouseService.CreateListenTableAsync();
    }
}