using Models.Entities.Enums;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Create;

public record Command(
    string Name,
    Guid AuthorId,
    AlbumType AlbumType,
    int ReleaseYear,
    Guid PreviewId,
    IFormFile PreviewImage) : ICommand<ResultDto>;