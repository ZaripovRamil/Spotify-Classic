using Models.Entities.Enums;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Create;

public record Command(
    string Id,
    string Name,
    string AuthorId,
    AlbumType AlbumType,
    int ReleaseYear,
    string PreviewId,
    IFormFile PreviewImage) : ICommand<ResultDto>;