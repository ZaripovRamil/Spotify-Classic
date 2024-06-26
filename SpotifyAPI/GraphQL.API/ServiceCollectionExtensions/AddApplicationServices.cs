﻿using Models.Configuration;
using Utils.ServiceCollectionExtensions;

namespace GraphQL.API.ServiceCollectionExtensions;

public static class AddApplicationServicesExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        
        services.Configure<JwtTokenSettings>(configuration.GetSection("JWTTokenSettings"));
        services.Configure<Hosts>(configuration.GetSection("Hosts"));
        
        services.AddHttpContextAccessor();
        services.AddJwtAuthentication(configuration);
        services.AddAllCors();

        //services.AddMediatorForAssembly(typeof(Program).Assembly);

        return services;
    }
}