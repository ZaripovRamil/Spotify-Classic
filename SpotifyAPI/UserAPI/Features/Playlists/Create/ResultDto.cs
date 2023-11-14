namespace UserAPI.Features.Playlists.Create;

public record ResultDto(bool IsSuccessful, string ResultMessage, string? PlaylistId);