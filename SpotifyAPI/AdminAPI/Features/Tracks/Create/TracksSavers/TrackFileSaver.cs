using System.Text;
using System.Text.Json;
using AdminAPI.Services;
using Models.Configuration;
using Models.Metadata;
using Utils.CQRS;
using Utils.CQRS.ServiceDefinition;

namespace AdminAPI.Features.Tracks.Create.TracksSavers;

[ServiceDefinition(ServiceLifetime.Scoped)]
public class TrackFileSaver : ISaver<Command, string>
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IMetadataCreator<Command,TrackMetadata> _metadataCreator;
    private bool _savedSuccessfully;

    public TrackFileSaver(IHttpClientFactory httpClientFactory, IMetadataCreator<Command,TrackMetadata> metadataCreator)
    {
        _httpClientFactory = httpClientFactory;
        _metadataCreator = metadataCreator;
    }

    public async Task<Result> PrepareAsync(Command item)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> UnPrepareAsync(Command item)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<string>> SaveAsync(Command item)
    {
        try
        {
            var client = _httpClientFactory.CreateClient(nameof(Hosts.StaticApi));
            var trackContent = new StreamContent(item.TrackFile.OpenReadStream());

            var metadata = await _metadataCreator.CreateMetadata(item);
            
            var formData = new MultipartFormDataContent
            {
                {trackContent, "File", $"{item.FileId}.mp3"},
                
                { new StringContent(
                        JsonSerializer.Serialize(metadata.Value),
                        Encoding.UTF8,
                        "application/json"),
                    "TrackMetadata" },

            };
            
            var res = await client.PostAsync("tracks/upload", formData);
            if (!res.IsSuccessStatusCode)
            {
                _savedSuccessfully = false;
                return new Result<string>(errors: await res.Content.ReadAsStringAsync());
            }
        }
        catch (Exception)
        {
            _savedSuccessfully = false;
            return new Result<string>(errors: "Network errors. Try again later");
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