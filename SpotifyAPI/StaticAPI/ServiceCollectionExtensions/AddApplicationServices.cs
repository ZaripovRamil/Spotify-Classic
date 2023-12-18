using External.Redis;
using Models.Configuration;
using Models.Metadata;
using StackExchange.Redis;
using StaticAPI.Features.Track.UploadTrack;
using StaticAPI.Services;
using StaticAPI.Services.Interfaces;
using Utils.ServiceCollectionExtensions;

namespace StaticAPI.ServiceCollectionExtensions;

public static class AddApplicationServicesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddTransient<IStorage, S3Storage>();
        services.AddTransient<IHlsConverter, HlsConverter>();
        services.AddTransient<IFileProcessingService, FileProcessingService>();
        services.AddTransient<IFileUploader, FileUploader>();
        services.AddHostedService<HlsConverterBackgroundService>();
        services.AddHostedService<RedisClearingService>();
        services.AddS3Client(configuration);
        services.AddMongoClient(configuration);

        services.AddScoped<IRepository<ImageMetadata>, ImageMetadataRepository>();
        services.AddScoped<IRepository<TrackMetadata>, TrackMetadataRepository>();
        
        services.AddMediatorForAssembly(typeof(Program).Assembly);
        services.Configure<JwtTokenSettings>(configuration.GetSection("JWTTokenSettings"));
        services.Configure<Hosts>(configuration.GetSection("Hosts"));
        
        
        services.AddSingleton<IConnectionMultiplexer>(x =>
        {
            var config = ConfigurationOptions.Parse("localhost:6379", true);

            return ConnectionMultiplexer.Connect(config);
        });
        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = "localhost:6379";
        });
        services.AddSingleton<IRedisCache, RedisCache>();
        
        services.AddJwtAuthorization(configuration);
        services.AddSwaggerWithAuthorization();
        services.AddAllCors();

        return services;
    }
}