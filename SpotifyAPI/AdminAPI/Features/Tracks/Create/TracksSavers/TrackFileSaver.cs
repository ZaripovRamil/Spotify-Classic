using AdminAPI.Services;
using Models.Configuration;
using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Create.TracksSavers;

public class TrackFileSaver : ISaver<Command, string>
{
    private readonly IHttpClientFactory _httpClientFactory;
    private bool _savedSuccessfully;

    public TrackFileSaver(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<Result<string>> SaveAsync(Command item)
    {
        try
        {
            var client = _httpClientFactory.CreateClient(nameof(Hosts.StaticApi));
            var formData = new MultipartFormDataContent();
            var trackContent = new StreamContent(item.TrackFile.OpenReadStream());
            formData.Add(trackContent, "file", $"{item.FileId}.mp3");

            var res = await client.PostAsync("upload", formData);
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
        return new Result<string>(value: item.FileId);
    }

    public Task<Result> UnSaveAsync(Command item)
    {
        if (!_savedSuccessfully) return Task.FromResult(new Result());
        throw new NotImplementedException();
    }
}