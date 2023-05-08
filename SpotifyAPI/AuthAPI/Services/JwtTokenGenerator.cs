using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models.Entities.Enums;

namespace AuthAPI.Services;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly JwtTokenSettings _jwtTokenSettings;
    private readonly IDbRequester _dbRequester;

    public JwtTokenGenerator(IDbRequester dbRequester, IOptions<JwtTokenSettings> jwtTokenSettingsConfig)
    {
        _dbRequester = dbRequester;
        _jwtTokenSettings = jwtTokenSettingsConfig.Value;
    }

    public async Task<string?> GenerateJwtTokenAsync(string username)
    {
        var foundUser = await _dbRequester.GetUserByUsername(username);
        if (foundUser == null) return null;
        var now = DateTime.UtcNow;
        var jwt = new JwtSecurityToken(
            issuer: _jwtTokenSettings.Issuer,
            audience: _jwtTokenSettings.Audience,
            notBefore: now,
            claims: GetIdentity(username, foundUser.Role).Claims,
            expires: now + TimeSpan.FromMinutes(_jwtTokenSettings.Lifetime),
            signingCredentials: new SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_jwtTokenSettings.Key)),
                SecurityAlgorithms.HmacSha256));

        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }

    public async Task<string?> GetRoleAsync(string username)
    {
        var user = await _dbRequester.GetUserByUsername(username);
        return user?.Role.ToString();
    }

    private static ClaimsIdentity GetIdentity(string username, Role role)
    {
        var claims = new List<Claim>
        {
            new(ClaimsIdentity.DefaultNameClaimType, username),
            new(ClaimsIdentity.DefaultRoleClaimType, role.ToString())
        };
        var claimsIdentity = new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
            ClaimsIdentity.DefaultRoleClaimType);
        return claimsIdentity;
    }
}