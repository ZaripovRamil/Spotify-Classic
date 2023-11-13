using DatabaseServices;
using Utils.ServiceCollectionExtensions;

namespace SearchAPI.ServiceCollectionExtensions;

public static class AddApplicationServicesExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddSwaggerWithAuthorization();
        services.AddAllCors();

        services.AddMediatorForAssembly(typeof(Program).Assembly);
        services.AddRepositories(configuration);
        services.AddSingleton<IDtoCreator, DtoCreator>();

        return services;
    }
}