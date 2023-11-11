using AdminAPI.Services;
using Models.Configuration;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Create.AlbumSaver;

public class AlbumPreviewSaver : ISaver<Command>
{
    private readonly IHttpClientFactory _httpClientFactory;
    private bool _savedSuccessfully;

    public AlbumPreviewSaver(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<Result> SaveAsync(Command item)
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
                return new Result(await res.Content.ReadAsStringAsync());
            }
        }
        catch (Exception e)
        {
            _savedSuccessfully = false;
            return new Result(e.Message);
        }

        _savedSuccessfully = true;
        return new Result();
    }

    public Task<Result> UnSaveAsync(Command item)
    {
        if (!_savedSuccessfully) return Task.FromResult(new Result());
        throw new NotImplementedException();
    }
}