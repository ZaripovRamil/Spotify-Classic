using Models.Configuration;
using Utils.ServiceCollectionExtensions;

namespace PaymentAPI.ServiceCollectionExtensions;

public static class AddApplicationServicesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JwtTokenSettings>(configuration.GetSection("JWTTokenSettings"));
        services.Configure<Hosts>(configuration.GetSection("Hosts"));

        services.AddMediatorForAssembly(typeof(Program).Assembly);
        services.AddRepositories(configuration);

        services.AddSignalR();

        services.AddJwtAuthentication(configuration);
        services.AddAuthorization();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerWithAuthorization();
        services.AddAllCors();

        return services;
    }
}