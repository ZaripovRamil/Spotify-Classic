using Models.Entities.Enums;

namespace AdminAPI.Features.Albums.Create;

public record RequestDto(string Name, Guid AuthorId, AlbumType AlbumType, int ReleaseYear, IFormFile PreviewFile);