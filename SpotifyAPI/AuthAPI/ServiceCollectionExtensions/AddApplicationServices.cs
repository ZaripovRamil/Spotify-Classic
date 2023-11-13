using AuthAPI.Features.GetStatistics;
using AuthAPI.Features.SignIn;
using DatabaseServices;
using Models.Configuration;
using Models.OAuth;
using Utils.ServiceCollectionExtensions;

namespace AuthAPI.ServiceCollectionExtensions;

public static class AddApplicationServicesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration configuration, IWebHostEnvironment environment)
    {
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

        services.AddIdentity(environment.IsDevelopment());
        services.AddRepositories(configuration);

        services.Configure<JwtTokenSettings>(configuration.GetSection("JWTTokenSettings"));
        services.Configure<Hosts>(configuration.GetSection("Hosts"));
        services.Configure<GoogleOptions>(configuration.GetSection("OAuth:Google"));

        services.AddScoped<IDtoCreator, DtoCreator>();
        services.AddScoped<IStatisticSnapshotCreator, StatisticSnapshotCreator>();
        services.AddTransient<Features.SignUp.OAuth.CommandHandler>();

        services.AddMediatorForAssembly(typeof(Program).Assembly)
            .AddPipelineBehaviors();
        services.AddJwtAuthorization(configuration);
        services.AddSwaggerWithAuthorization();
        services.AddAllCors();
        
        return services;
    }
}