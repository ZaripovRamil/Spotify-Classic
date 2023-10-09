using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models.Configuration;
using Models.Entities;
using Models.Entities.Enums;

namespace AuthAPI.Services;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly JwtTokenSettings _jwtTokenSettings;
    private readonly UserManager<User> _userManager; 

    public JwtTokenGenerator(IOptions<JwtTokenSettings> jwtTokenSettingsConfig, UserManager<User> userManager)
    {
        _userManager = userManager;
        _jwtTokenSettings = jwtTokenSettingsConfig.Value;
    }

    public async Task<string?> GenerateJwtTokenAsync(string username, TimeSpan additionalLifetime)
    {
        var user = await _userManager.FindByNameAsync(username);
        if (user is null) return null;
        var now = DateTime.UtcNow;
        var jwt = new JwtSecurityToken(
            issuer: _jwtTokenSettings.Issuer,
            audience: _jwtTokenSettings.Audience,
            notBefore: now,
            claims: GetIdentity(user, user.Role).Claims,
            expires: now + TimeSpan.FromMinutes(_jwtTokenSettings.Lifetime) + additionalLifetime,
            signingCredentials: new SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_jwtTokenSettings.Key)),
                SecurityAlgorithms.HmacSha256));

        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }

    public async Task<string?> GetRoleAsync(string username)
    {
        var user = await _userManager.FindByNameAsync(username);
        return user?.Role.ToString();
    }

    public Task<bool> ValidateTokenAsync(string token)
    {
        var tokenHandler = new JwtSecurityTokenHandler();

        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = _jwtTokenSettings.Issuer,
            ValidAudience = _jwtTokenSettings.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_jwtTokenSettings.Key))
        };

        try
        {
            tokenHandler.ValidateToken(token, validationParameters, out _);
            return Task.FromResult(true);
        }
        catch
        {
            return Task.FromResult(false);
        }
    }

    private static ClaimsIdentity GetIdentity(User user, Role role)
    {
        var claims = new List<Claim>
        {
            new(ClaimsIdentity.DefaultNameClaimType, user.UserName!),
            new("Id", user.Id),
            new(ClaimsIdentity.DefaultRoleClaimType, role.ToString()),
        };
        var claimsIdentity = new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
            ClaimsIdentity.DefaultRoleClaimType);
        return claimsIdentity;
    }
}