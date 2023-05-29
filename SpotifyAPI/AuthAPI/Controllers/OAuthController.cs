using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Models.OAuth;

namespace AuthAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OAuthController : Controller
{
    private readonly GoogleOptions _googleOptions;
    private readonly ApplicationHosts _applicationHosts;

    public OAuthController(IOptions<GoogleOptions> googleOptions, IOptions<ApplicationHosts> applicationHosts)
    {
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
}