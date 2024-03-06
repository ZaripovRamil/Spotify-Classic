using AuthAPI.Configuration;
using AuthAPI.Features.GetStatistics;
using AuthAPI.Features.SignIn;
using FluentValidation;
using Models.Configuration;
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

        services.AddScoped<IStatisticSnapshotCreator, StatisticSnapshotCreator>();

        services.AddMediatorForAssembly(typeof(Program).Assembly)
            .AddPipelineBehaviors();
        services.AddValidatorsFromAssembly(typeof(Program).Assembly);
        
        services.AddJwtAuthorization(configuration);
        services.AddAuthorization();
        services.AddSwaggerWithAuthorization();
        services.AddAllCors();
        
        return services;
    }
}