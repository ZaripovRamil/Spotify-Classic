using AdminAPI.Services;
using Models.Configuration;
using Utils.CQRS;
using Utils.CQRS.ServiceDefinition;

namespace AdminAPI.Features.Albums.Create.AlbumSavers;

[ServiceDefinition(ServiceLifetime.Scoped)]
public class PreviewSaver : ISaver<Command, string>
{
    private readonly IHttpClientFactory _httpClientFactory;
    private bool _savedSuccessfully;

    public PreviewSaver(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<Result<string>> SaveAsync(Command item)
    {
        try
        {
            var client = _httpClientFactory.CreateClient(nameof(Hosts.StaticApi));
            var formData = new MultipartFormDataContent();
            var albumContent = new StreamContent(item.PreviewImage.OpenReadStream());
            formData.Add(albumContent, "file", $"{item.PreviewId}.jpg");

            var res = await client.PostAsync("previews/upload", formData);
            if (!res.IsSuccessStatusCode)
            {
                _savedSuccessfully = false;
                return new Result<string>(errors: await res.Content.ReadAsStringAsync());
            }
        }
        catch (Exception e)
        {
            _savedSuccessfully = false;
            return new Result<string>(errors: e.Message);
        }

        _savedSuccessfully = true;
        return new Result<string>(value: item.PreviewId);
    }

    public Task<Result> UnSaveAsync(Command item)
    {
        if (!_savedSuccessfully) return Task.FromResult(new Result());
        throw new NotImplementedException();
    }
}