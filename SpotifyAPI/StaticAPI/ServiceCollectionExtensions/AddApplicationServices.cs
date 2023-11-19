using Models.Configuration;
using StaticAPI.Features.Track.UploadTrack;
using StaticAPI.Services;
using Utils.ServiceCollectionExtensions;

namespace StaticAPI.ServiceCollectionExtensions;

public static class AddApplicationServicesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddTransient<IStorage, S3Storage>();
        services.AddTransient<IHlsConverter, HlsConverter>();
        services.AddHostedService<HlsConverterBackgroundService>();
        services.AddS3Client(configuration);

        services.AddMediatorForAssembly(typeof(Program).Assembly);
        services.Configure<JwtTokenSettings>(configuration.GetSection("JWTTokenSettings"));
        services.Configure<Hosts>(configuration.GetSection("Hosts"));

        services.AddJwtAuthorization(configuration);
        services.AddSwaggerWithAuthorization();
        services.AddAllCors();

        return services;
    }
}