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
    private static readonly object Lock = new();
    private static string _lockedItemId = string.Empty;
    private static DateTime _lockedTimestamp = DateTime.MinValue;

    public PreviewSaver(IHttpClientFactory httpClientFactory, IMetadataCreator<Command,ImageMetadata> metadataCreator )
    {
        _httpClientFactory = httpClientFactory;
        _metadataCreator = metadataCreator;
    }

    public Task<Result> PrepareAsync(Command item)
    {
        var successful = false;
        lock (Lock)
        {
            if (string.IsNullOrEmpty(_lockedItemId) || _lockedTimestamp.AddMinutes(1) < DateTime.Now)
            {
                _lockedItemId = item.Id;
                _lockedTimestamp = DateTime.Now;
                successful = true;
            }
        }

        if (successful)
            return ValidateAsync(item);
        
        var res = new Result();
        res.Fail();
        return Task.FromResult(res);
    }

    private async Task<Result> ValidateAsync(Command item)
    {
        var validator = new PreviewValidator(_httpClientFactory);
        return await validator.ValidateAsync(item);
    }
    
    public Task<Result> UnPrepareAsync(Command item)
    {
        lock (Lock)
        {
            if (_lockedItemId == item.Id)
            {
                _lockedItemId = string.Empty;
                _lockedTimestamp = DateTime.MinValue;
                return Task.FromResult(new Result());
            }
        }

        var res = new Result();
        res.Fail();
        return Task.FromResult(res);
    }

    public async Task<Result<string>> SaveAsync(Command item)
    {
        await UnPrepareAsync(item);
        try
        {
            var client = _httpClientFactory.CreateClient(nameof(Hosts.StaticApi));
            
            var albumContent = new StreamContent(item.PreviewImage.OpenReadStream());

            var metadata = await _metadataCreator.CreateMetadata(item);
            var formData = new MultipartFormDataContent
            {
                {albumContent, "File", $"{item.PreviewId}.jpg"},
                
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