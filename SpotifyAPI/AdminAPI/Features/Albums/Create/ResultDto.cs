namespace AdminAPI.Features.Albums.Create;

public record ResultDto(bool IsSuccessful, string ResultMessage, string? AlbumId);