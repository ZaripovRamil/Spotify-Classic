using Amazon.S3;

namespace StaticAPI.ServiceCollectionExtensions;

public static class AddS3ClientExtension
{
    public static IServiceCollection AddS3Client(this IServiceCollection services, IConfiguration configuration)
    {
        var config = configuration.GetSection("S3Client").Get<Configuration.AmazonS3Config>();
        if (config is null) throw new ArgumentException("S3 Config is not provided in the current configuration");
        var clientConfig = new AmazonS3Config
        {
            AuthenticationRegion = config.AuthenticationRegion,
            ServiceURL = config.ServiceUrl,
            ForcePathStyle = config.ForcePathStyle
        };
        services.AddSingleton<IAmazonS3>(new AmazonS3Client(config.AccessKey, config.SecretKey, clientConfig));
        return services;
    }
}