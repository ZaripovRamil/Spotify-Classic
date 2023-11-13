using Models.Configuration;
using Polly;
using Polly.Contrib.WaitAndRetry;

namespace AdminAPI.ServiceCollectionExtensions;

public static class AddHttpClientsExtension
{
    public static IServiceCollection AddHttpClients(this IServiceCollection services, IConfiguration configuration)
    {
        var hosts = (Hosts)Activator.CreateInstance(typeof(Hosts))!;
        configuration.GetSection("Hosts").Bind(hosts);

        services.AddHttpClient(nameof(Hosts.StaticApi),
                client => client.BaseAddress = new Uri($"http://{hosts.StaticApi}/"))
            .AddRetryPolicy();
        services.AddHttpClient(nameof(Hosts.SearchApi),
                client => client.BaseAddress = new Uri($"http://{hosts.SearchApi}/search"))
            .AddRetryPolicy();
        
        return services;
    }

    private static void AddRetryPolicy(this IHttpClientBuilder builder)
    {
        builder.AddTransientHttpErrorPolicy(pb =>
            pb.WaitAndRetryAsync(Backoff.DecorrelatedJitterBackoffV2(
                TimeSpan.FromMilliseconds(200), 5)));
    }
}