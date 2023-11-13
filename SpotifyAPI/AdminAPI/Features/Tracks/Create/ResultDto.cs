namespace AdminAPI.Features.Tracks.Create;

public record ResultDto(bool IsSuccessful, string ResultMessage, string? TrackId);