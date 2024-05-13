﻿using Microsoft.AspNetCore.Http;
using Models.DTO.Auth;

namespace GraphQL.Contracts.AuthAPI.Auth;
[ExtendObjectType("Mutation")]
public class LoginMutation : GraphQLRequest
{
    public LoginMutation(IHttpContextAccessor httpContextAccessor) : base("http://localhost:5209", httpContextAccessor)
    {
    }

    public async Task<LoginResult?> Login(LoginData loginData)
    {
        return await Proxy.PostAsync<LoginData, LoginResult>(TargetHostname + "/auth/login", null, loginData);
    }
}