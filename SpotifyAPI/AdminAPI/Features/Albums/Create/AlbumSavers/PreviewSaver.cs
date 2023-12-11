using System.Text;
using System.Text.Json;
using AdminAPI.Services;
using Models.Configuration;
using Models.Metadata;
using Utils.CQRS;
using Utils.CQRS.ServiceDefinition;

namespace AdminAPI.Features.Albums.Create.AlbumSavers;

[ServiceDefinition(ServiceLifetime.Scoped)]
public class PreviewSaver : ISaver<Command, string>
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IMetadataCreator<Command,ImageMetadata> _metadataCreator;
    private bool _savedSuccessfully;

    public PreviewSaver(IHttpClientFactory httpClientFactory, IMetadataCreator<Command,ImageMetadata> metadataCreator )
    {
        _httpClientFactory = httpClientFactory;
        _metadataCreator = metadataCreator;
    }

    public async Task<Result<string>> SaveAsync(Command item)
    {
        try
        {
            var client = _httpClientFactory.CreateClient(nameof(Hosts.StaticApi));
            
            var albumContent = new StreamContent(item.PreviewImage.OpenReadStream());

            var metadata = await _metadataCreator.CreateMetadata(item);
            
            var formData = new MultipartFormDataContent
            {
                {albumContent, "file", $"{item.PreviewId}.jpg"},
                
                { new StringContent(
                        JsonSerializer.Serialize(metadata.Value),
                        Encoding.UTF8,
                        "application/json"),
                    "ImageMetadata" },

            };

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