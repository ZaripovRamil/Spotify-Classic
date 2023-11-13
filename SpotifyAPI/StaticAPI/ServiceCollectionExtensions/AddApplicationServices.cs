using Models.Configuration;
using StaticAPI.Services;
using Utils.ServiceCollectionExtensions;

namespace StaticAPI.ServiceCollectionExtensions;

public static class AddApplicationServicesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddTransient<IFileProvider, FileProvider>();
        services.AddTransient<IHlsConverter, HlsConverter>();

        services.AddMediatorForAssembly(typeof(Program).Assembly);
        services.Configure<JwtTokenSettings>(configuration.GetSection("JWTTokenSettings"));
        services.Configure<Hosts>(configuration.GetSection("Hosts"));

        services.AddJwtAuthorization(configuration);
        services.AddSwaggerWithAuthorization();
        services.AddAllCors();

        return services;
    }
}