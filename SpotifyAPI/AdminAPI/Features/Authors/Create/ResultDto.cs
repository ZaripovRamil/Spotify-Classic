namespace AdminAPI.Features.Authors.Create;

public record ResultDto(bool IsSuccessful, string ResultMessage, string? AuthorId);