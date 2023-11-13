using FluentValidation;
using Models.Configuration;
using Utils.ServiceCollectionExtensions;

namespace AdminAPI.ServiceCollectionExtensions;

public static class AddApplicationServicesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JwtTokenSettings>(configuration.GetSection("JWTTokenSettings"));
        services.Configure<Hosts>(configuration.GetSection("Hosts"));

        services.AddHttpClients(configuration);
        services.AddRepositories(configuration);
        services.AddValidatorsFromAssembly(typeof(Program).Assembly);
        services.AddDefinedServices(typeof(Program).Assembly);
        services.AddMediatorForAssembly(typeof(Program).Assembly)
            .AddPipelineBehaviors();

        services.AddJwtAuthorization(configuration);
        services.AddSwaggerWithAuthorization();
        services.AddAllCors();

        return services;
    }
}