using GraphQL.Contracts.AuthAPI.Auth;
using Microsoft.AspNetCore.Http;
using Models.DTO.Auth;

namespace GraphQL.Contracts.AuthAPI.Registration;

[ExtendObjectType("Mutation")]
public class RegistrationMutation : GraphQLRequest
{
    public RegistrationMutation(IHttpContextAccessor contextAccessor) : base("http://localhost:7249", contextAccessor)
    {
    }

    public async Task<RegistrationResult?> Register(RegistrationData registrationData)
    {
        return await Proxy.PostAsync<RegistrationData, RegistrationResult>(TargetHostname + "registration/add", null,
            registrationData);
    }
}