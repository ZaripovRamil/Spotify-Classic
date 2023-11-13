namespace AdminAPI.Features.Tracks.Create;

public record RequestDto(string Name, string AlbumId, string[] GenreIds, IFormFile TrackFile);