namespace AdminAPI.Features.Genres.Create;

public record ResultDto(bool IsSuccessful, string ResultMessage, string? GenreId);