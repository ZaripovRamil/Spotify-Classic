using DatabaseServices.Repositories;
using Models.Configuration;
using Models.Entities;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Create;

public interface ISaver<in T>
{
    Task<Result> SaveAsync(T item);
    Task<Result> UnSaveAsync(T item);
}

public class AlbumDbSaver : ISaver<Command>
{
    private readonly IAlbumRepository _albumRepository;
    private bool _savedSuccessfully;
    private Album _album = default!;

    public AlbumDbSaver(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<Result> SaveAsync(Command item)
    {
        _album = new Album(item.Name, item.AuthorId.ToString(), item.AlbumType, item.ReleaseYear,
            item.PreviewId.ToString());
        try
        {
            await _albumRepository.AddAsync(_album);
        }
        catch (Exception e)
        {
            _savedSuccessfully = false;
            return new Result(e.Message);
        }
        _savedSuccessfully = true;
        return new Result();
    }

    public async Task<Result> UnSaveAsync(Command item)
    {
        if (!_savedSuccessfully) return new Result();
        try
        {
            await _albumRepository.DeleteAsync(_album);
        }
        catch (Exception e)
        {
            return new Result(e.Message);
        }
        
        return new Result();
    }
}

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

public record AlbumPreview(IFormFile PreviewFile, string PreviewId);