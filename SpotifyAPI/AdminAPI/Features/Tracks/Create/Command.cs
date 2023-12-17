using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Create;

public record Command(string Name, string AlbumId, string FileId, string[] GenreIds, string? TrackId, IFormFile TrackFile) : ICommand<ResultDto>;