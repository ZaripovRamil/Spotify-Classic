using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;

namespace AdminAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly HttpClient _clientToStatic = new() { BaseAddress = new Uri("https://localhost:7153/tracks/") };
    private readonly HttpClient _clientToDb = new() { BaseAddress = new Uri("https://localhost:7248/track/") };
    
    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var tracks = await _clientToDb.GetFromJsonAsync<IEnumerable<TrackLight>>("get");
        return new JsonResult(tracks);
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var track = await _clientToDb.GetFromJsonAsync<TrackLight>($"get/id/{id}");
        return new JsonResult(track);
    }

    // TODO: split it up
    [HttpPost("add")]
    public async Task<IActionResult> AddAsync([FromForm] TrackCreationDataWithFile creationDataWithFile)
    {
        var creationData = new TrackCreationData
        {
            AlbumId = creationDataWithFile.AlbumId,
            GenreIds = creationDataWithFile.GenreIds,
            Name = creationDataWithFile.Name,
        };
        var json = JsonSerializer.Serialize(creationData);
        var dbResponse = await _clientToDb.PostAsync("add", new StringContent(json, Encoding.UTF8, "application/json"));
        var responseContent = await dbResponse.Content.ReadAsStringAsync();
        var trackCreationResult = JsonSerializer.Deserialize<TrackCreationResult>(responseContent,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        if (trackCreationResult is null || !trackCreationResult.IsSuccessful)
            return BadRequest(new TrackCreationResult
            {
                IsSuccessful = false,
                ResultMessage = trackCreationResult?.ResultMessage ?? "Unknown error"
            });
        var trackContent = new StreamContent(creationDataWithFile.TrackFile.OpenReadStream());
        var formData = new MultipartFormDataContent();
        formData.Add(trackContent, "file", $"{trackCreationResult.TrackId!}.mp3");
        var staticResponse = await _clientToStatic.PostAsync("upload", formData);
        if (staticResponse.IsSuccessStatusCode)
            return new JsonResult(trackCreationResult);
        await _clientToDb.DeleteAsync($"delete/{trackCreationResult.TrackId}");
        return BadRequest(new TrackCreationResult
        {
            IsSuccessful = false,
            ResultMessage = staticResponse.RequestMessage?.ToString() ?? "Unknown error",
        });
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteAsync(string id)
    {
        var response = await _clientToDb.DeleteAsync($"delete/{id}");
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateAsync(string id, TrackUpdateData trackUpdateData)
    {
        var json = JsonSerializer.Serialize(trackUpdateData);
        var response =
            await _clientToDb.PutAsync($"update/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }
}

public class TrackCreationDataWithFile : TrackCreationData
{
    public IFormFile TrackFile { get; set; }
}