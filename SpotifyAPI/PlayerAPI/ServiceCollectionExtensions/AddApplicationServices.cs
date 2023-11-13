using DatabaseServices;
using Models.Configuration;
using Utils.ServiceCollectionExtensions;

namespace PlayerAPI.ServiceCollectionExtensions;

public static class AddApplicationServicesExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JwtTokenSettings>(configuration.GetSection("JWTTokenSettings"));
        services.Configure<Hosts>(configuration.GetSection("Hosts"));

        services.AddRepositories(configuration);
        services.AddJwtAuthorization(configuration);
        services.AddSwaggerWithAuthorization();
        services.AddAllCors();

        services.AddMediatorForAssembly(typeof(Program).Assembly);
        services.AddSingleton<IDtoCreator, DtoCreator>();

        return services;
    }
}