using System.Net.Http.Headers;
using System.Text.Json;
using AuthAPI.Services;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Models.DTO.BackToFront.Auth;
using Models.Entities;
using Models.OAuth;

namespace AuthAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OAuthController : Controller
{
    private readonly GoogleOptions _googleOptions;
    private readonly ApplicationHosts _applicationHosts;
    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public OAuthController(IOptions<GoogleOptions> googleOptions, IOptions<ApplicationHosts> applicationHosts,
        SignInManager<User> signInManager, UserManager<User> userManager, IJwtTokenGenerator jwtTokenGenerator)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _jwtTokenGenerator = jwtTokenGenerator;
        _googleOptions = googleOptions.Value;
        _applicationHosts = applicationHosts.Value;
    }

    [HttpGet("google/entry")]
    public async Task<IActionResult> GoogleEntry()
    {
        const string scope = "openid email profile";
        return Redirect(
            $"https://accounts.google.com/o/oauth2/v2/auth?response_type=code&client_id={_googleOptions.ClientId}&redirect_uri=http://localhost:{_applicationHosts.UsersFrontend}/oauth/google/callback&scope={scope}&state={_googleOptions.State}&nonce={new Random().Next()}");
    }

    [HttpPost("google/callback")]
    public async Task<IActionResult> GetAccessToken([FromBody] GoogleCallbackDto dto)
    {
        var client = new HttpClient();
        var content = new FormUrlEncodedContent(new KeyValuePair<string, string>[]
        {
            new("client_id", _googleOptions.ClientId),
            new("client_secret", _googleOptions.ClientSecret),
            new("redirect_uri", $"http://localhost:{_applicationHosts.UsersFrontend}/oauth/google/callback"),
            new("grant_type", "authorization_code"),
            new("code", dto.Code)
        });
        var resp = await client.PostAsync(GoogleDefaults.TokenEndpoint, content);
        var respContent = await resp.Content.ReadFromJsonAsync<GoogleResult>();
        return new JsonResult(respContent);
    }

    [HttpPost("google/get/profileInfo")]
    public async Task<IActionResult> GetProfileInfo([FromBody] GoogleUserDto userDto)
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userDto.AccessToken);
        var response = await client.GetAsync(GoogleDefaults.UserInfoEndpoint);
        if (!response.IsSuccessStatusCode) return BadRequest();
        var user = await response.Content.ReadFromJsonAsync<GoogleUserInfoDto>(new JsonSerializerOptions
            { PropertyNameCaseInsensitive = true });
        return new JsonResult(user);
    }

    [HttpGet("google/login")]
    public async Task<IActionResult> LoginAsync([FromBody] GoogleLoginData loginData)
    {
        try
        {
            var payload = await GoogleJsonWebSignature.ValidateAsync(loginData.IdToken);
            var user = await _userManager.FindByLoginAsync("Google", payload.Subject);
            if (user is null && await _userManager.FindByEmailAsync(payload.Email) is null)
            {
                var registerResult = await RegisterAsync(loginData);
                if (registerResult is BadRequestResult) return registerResult;
            }
            var additionalLifetime = await _jwtTokenGenerator.GetRoleAsync(payload.Subject) != "Admin"
                ? TimeSpan.FromDays(14)
                : TimeSpan.Zero;
            var token = await _jwtTokenGenerator.GenerateJwtTokenAsync(payload.Subject, additionalLifetime);
            return token is null
                ? new JsonResult(new LoginResult(false, "", "Authorization failed"))
                : new JsonResult(new LoginResult(true, token, "Successful"));
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpGet("google/register")]
    public async Task<IActionResult> RegisterAsync([FromBody] GoogleLoginData loginData)
    {
        try
        {
            var payload = await GoogleJsonWebSignature.ValidateAsync(loginData.IdToken);
            var user = new User(payload.Subject, payload.Email, payload.Name);
            var password = Guid.NewGuid().ToString();
            var result = await _userManager.CreateAsync(user, password);
            if (!result.Succeeded)
                return new JsonResult(new RegistrationResult(RegistrationCode.UnknownError, null));
            await _userManager.AddLoginAsync(user, new UserLoginInfo("Google", payload.Subject, "OAuth"));
            return new JsonResult(new RegistrationResult(RegistrationCode.Successful,
                await _userManager.FindByEmailAsync(payload.Email)));
        }
        catch
        {
            return BadRequest();
        }
    }
}