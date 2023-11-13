using Models.Entities.Enums;

namespace AdminAPI.Features.Albums.Create;

public record RequestDto(string Name, string AuthorId, AlbumType AlbumType, int ReleaseYear, IFormFile PreviewFile);