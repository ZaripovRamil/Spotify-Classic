using System.Text.Json;

namespace Database.Extensions;

public static class DatabaseRequestGenerator
{
    private static readonly JsonSerializerOptions Options = new (){PropertyNameCaseInsensitive = true};
    public static async Task<T?> GetDataAsync<T>(this HttpClient client, string uri)
    {
        var message = new HttpRequestMessage();
        message.Method = HttpMethod.Get;
        message.RequestUri = new Uri("http://localhost:5096/"+uri);
        var content = await (await client.SendAsync(message)).Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<T>(content, Options);
        return result;
    }

    public static async void PostDataAsync(this HttpClient client, string uri, object data)
    {
        var message = new HttpRequestMessage();
        message.Method = HttpMethod.Post;
        message.Content = JsonContent.Create(data);
        message.RequestUri = new Uri("http://localhost:5096/"+uri);
        await client.SendAsync(message);
    }
}