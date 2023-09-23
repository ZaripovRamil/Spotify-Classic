using System.Text;
using System.Text.Json;
using AdminAPI.ModelsExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Full;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;

namespace AdminAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class AlbumsController : Controller
{
    private readonly HttpClient _clientToDb;
    private readonly HttpClient _clientToSearch;
    private readonly HttpClient _clientToStatic;

    public AlbumsController(IOptions<Hosts> hostsOptions)
    {
        _clientToSearch = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.SearchApi}/search")};
        _clientToDb = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.DatabaseApi}/album/") };
        _clientToStatic = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.StaticApi}/previews/") };
    }
    
    // [HttpGet("get")]
    // public async Task<IActionResult> GetAllAsync()
    // {
    //     var albums = await _clientToDb.GetFromJsonAsync<IEnumerable<AlbumFull>>("get");
    //     return new JsonResult(albums);
    // }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var album = await _clientToDb.GetFromJsonAsync<AlbumFull>($"get/id/{id}");
        return new JsonResult(album);
    }

    // actually garbage, but looks not so bad now
    [HttpPost("add")]
    public async Task<IActionResult> AddAsync([FromForm] AlbumCreationDataWithFile creationDataWithFile)
    {
        var creationData = (AlbumCreationData)creationDataWithFile;
        var albumCreationResult = await AddToDbAsync(creationData);
        if (!albumCreationResult.IsSuccessful)
            return BadRequest(albumCreationResult);

        var album = await _clientToDb.GetFromJsonAsync<AlbumFull>($"get/id/{albumCreationResult.AlbumId!}");
        var staticResponse =
            await UploadContentToStaticAsync(creationDataWithFile.PreviewFile, album!.PreviewId);
        if (staticResponse.IsSuccessStatusCode) return new JsonResult(albumCreationResult);
        
        // if static API rejected uploading, delete album from database. what if this fails too? cry, i suppose.
        await DeleteAsync(albumCreationResult.AlbumId!);
        return BadRequest(new AlbumCreationResult
        {
            IsSuccessful = false,
            ResultMessage = await staticResponse.Content.ReadAsStringAsync()
        });
    }

    private async Task<AlbumCreationResult> AddToDbAsync(AlbumCreationData creationData)
    {
        var json = JsonSerializer.Serialize(creationData);
        var resp = await _clientToDb.PostAsync("add", new StringContent(json, Encoding.UTF8, "application/json"));
        var respContent = await resp.Content.ReadAsStreamAsync();
        var albumCreationResult = await JsonSerializer.DeserializeAsync<AlbumCreationResult>(respContent,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        if (albumCreationResult is null)
            return new AlbumCreationResult
            {
                IsSuccessful = false,
                ResultMessage = "Unknown database error"
            };
        return albumCreationResult;
    }

    private async Task<HttpResponseMessage> UploadContentToStaticAsync(IFormFile album, string previewId)
    {
        var formData = new MultipartFormDataContent();
        var albumContent = new StreamContent(album.OpenReadStream());
        formData.Add(albumContent, "file", $"{previewId}.jpg");

        return await _clientToStatic.PostAsync("upload", formData);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteAsync(string id)
    {
        var response = await _clientToDb.DeleteAsync($"delete/{id}");
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateAsync(string id, [FromBody] AlbumUpdateData albumUpdateData)
    {
        var json = JsonSerializer.Serialize(albumUpdateData);
        var response =
            await _clientToDb.PutAsync($"update/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }
    
    [HttpGet("get")]
    public async Task<IActionResult> GetWithFiltersAsync([FromQuery] string? albumType, [FromQuery] int? tracksMin,
        [FromQuery] int? tracksMax, [FromQuery] int? maxCount, [FromQuery] string? sortBy, [FromQuery] string? search)
    {
        var albums =
            await _clientToDb.GetFromJsonAsync<List<AlbumFull>>(
                $"get?albumType={albumType}&tracksMin={tracksMin}&tracksMax={tracksMax}&maxCount={maxCount}&search={search}");
        Func<AlbumFull, IComparable> sort = sortBy?.ToLower() switch
        {
            "id" => album => album.Id,
            "name" => album => album.Name,
            "author" => album => album.Author.Name,
            "type" => album => album.Type,
            _ => album => album.Name
        };
        return new JsonResult(albums?.OrderBy(sort));
    }

    [HttpGet("search")]
    public async Task<IActionResult> FindAlbumByAuthorName([FromQuery] string? query)
    {
        var albums = await _clientToSearch.GetFromJsonAsync<IEnumerable<Album>>(
            $"albums/by/author?query={query}");
        return new JsonResult(albums?.Select(a => new AlbumFull(a)));
    }
}