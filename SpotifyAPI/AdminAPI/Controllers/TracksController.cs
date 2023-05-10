using System.Security.Claims;
using System.Text;
using System.Text.Json;
using AdminAPI.ModelsExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Full;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;

namespace AdminAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly HttpClient _clientToStatic = new() { BaseAddress = new Uri("https://localhost:7153/tracks/") };
    private readonly HttpClient _clientToDb = new() { BaseAddress = new Uri("https://localhost:7248/track/") };
    
    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var tracks = await _clientToDb.GetFromJsonAsync<IEnumerable<TrackFull>>("get");
        return new JsonResult(tracks);
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var track = await _clientToDb.GetFromJsonAsync<TrackFull>($"get/id/{id}");
        return new JsonResult(track);
    }

    // actually garbage, but looks not so bad now
    [HttpPost("add")]
    public async Task<IActionResult> AddAsync([FromForm] TrackCreationDataWithFile creationDataWithFile)
    {
        var creationData = (TrackCreationData)creationDataWithFile;
        var trackCreationResult = await AddToDbAsync(creationData);
        if (!trackCreationResult.IsSuccessful)
            return BadRequest(trackCreationResult);

        var track = await _clientToDb.GetFromJsonAsync<TrackFull>($"get/id/{trackCreationResult.TrackId}");
        var staticResponse =
            await UploadContentToStaticAsync(creationDataWithFile.TrackFile, track!.FileId);
        if (staticResponse.IsSuccessStatusCode) return new JsonResult(trackCreationResult);
        
        // if static API rejected uploading, delete track from database. what if this fails too? cry, i suppose.
        await DeleteAsync(trackCreationResult.TrackId!);
        return BadRequest(new TrackCreationResult
        {
            IsSuccessful = false,
            ResultMessage = await staticResponse.Content.ReadAsStringAsync()
        });
    }

    private async Task<TrackCreationResult> AddToDbAsync(TrackCreationData creationData)
    {
        var json = JsonSerializer.Serialize(creationData);
        var resp = await _clientToDb.PostAsync("add", new StringContent(json, Encoding.UTF8, "application/json"));
        var respContent = await resp.Content.ReadAsStreamAsync();
        var trackCreationResult = await JsonSerializer.DeserializeAsync<TrackCreationResult>(respContent,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        if (trackCreationResult is null)
            return new TrackCreationResult
            {
                IsSuccessful = false,
                ResultMessage = "Unknown database error"
            };
        return trackCreationResult;
    }

    private async Task<HttpResponseMessage> UploadContentToStaticAsync(IFormFile track, string trackId)
    {
        var formData = new MultipartFormDataContent();
        var trackContent = new StreamContent(track.OpenReadStream());
        formData.Add(trackContent, "file", $"{trackId}.mp3");

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
    public async Task<IActionResult> UpdateAsync(string id, TrackUpdateData trackUpdateData)
    {
        var json = JsonSerializer.Serialize(trackUpdateData);
        var response =
            await _clientToDb.PutAsync($"update/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }
}