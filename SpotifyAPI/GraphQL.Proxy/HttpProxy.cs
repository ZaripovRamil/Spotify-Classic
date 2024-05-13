using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace GraphQL.Proxy;

public interface IHttpProxy
{
    Task<TOut?> GetAsync<TOut>(string path, Dictionary<string, string> queryParams, string? authorizationToken = null);

    Task<TOut?> PostAsync<TIn, TOut>(string path, Dictionary<string, string> queryParams, TIn bodyParams,
        string? authorizationToken = null);
}

public class HttpProxy : IHttpProxy
{
    private readonly HttpClient _httpClient;

    public HttpProxy()
    {
        _httpClient = new HttpClient();
    }

    public async Task<TOut?> GetAsync<TOut>(string path, Dictionary<string, string>? queryParams,
        string? authorizationToken = null)
    {
        var request = BuildGetMessage(path, queryParams, authorizationToken);

        var response = await _httpClient.SendAsync(request);
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<TOut>(content);
    }

    private static HttpRequestMessage BuildGetMessage(string path, Dictionary<string, string>? queryParams,
        string? authorizationToken = null)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, path);
        request.RequestUri = AddQueryParameters(request.RequestUri, queryParams);
        if (!string.IsNullOrEmpty(authorizationToken))
        {
            request.Headers.Add("Authorization", authorizationToken);
            //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authorizationToken);
        }

        return request;
    }

    public async Task<TOut?> PostAsync<TIn, TOut>(string path, Dictionary<string, string>? queryParams, TIn bodyParams,
        string? authorizationToken = null)
    {
        var request = BuildPostMessage(path, queryParams, bodyParams, authorizationToken);

        var response = await _httpClient.SendAsync(request);
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<TOut>(content);
    }

    public async Task<TOut?> PutAsync<TIn, TOut>(string path, Dictionary<string, string>? queryParams, TIn bodyParams,
        string? authorizationToken = null)
    {
        var request = BuildPutMessage(path, queryParams, bodyParams, authorizationToken);

        var response = await _httpClient.SendAsync(request);
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<TOut>(content);
    }

    private static HttpRequestMessage BuildPostMessage<TIn>(string path, Dictionary<string, string>? queryParams,
        TIn bodyParams, string? authorizationToken)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, path);
        request.RequestUri = AddQueryParameters(request.RequestUri, queryParams);
        request.Content = new StringContent(JsonConvert.SerializeObject(bodyParams), Encoding.UTF8, "application/json");
        if (!string.IsNullOrEmpty(authorizationToken))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authorizationToken);
        }

        return request;
    }

    private static HttpRequestMessage BuildPutMessage<TIn>(string path, Dictionary<string, string>? queryParams,
        TIn bodyParams, string? authorizationToken)
    {
        var request = new HttpRequestMessage(HttpMethod.Put, path);
        request.RequestUri = AddQueryParameters(request.RequestUri, queryParams);
        request.Content = new StringContent(JsonConvert.SerializeObject(bodyParams), Encoding.UTF8, "application/json");
        if (!string.IsNullOrEmpty(authorizationToken))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authorizationToken);
        }

        return request;
    }

    private static Uri? AddQueryParameters(Uri? path, Dictionary<string, string>? queryParams)
    {
        if (queryParams == null)
            return path;
        return new Uri(path + "?" + string.Join("&", queryParams.Select(kvp => $"{kvp.Key}={kvp.Value}")));
    }
}