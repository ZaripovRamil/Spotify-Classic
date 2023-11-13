using DatabaseServices.Repositories;
using Models.DTO.BackToFront.Full;
using Utils.CQRS;
using static Models.Entities.ValidationErrors.AlbumErrors;

namespace AdminAPI.Features.Albums.Get.ById;

public class QueryHandler : IQueryHandler<Query, AlbumFull>
{
    private readonly IAlbumRepository _albumRepository;

    public QueryHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<Result<AlbumFull>> Handle(Query request, CancellationToken cancellationToken)
    {
        var album = await _albumRepository.GetByIdAsync(request.Id);
        return album is null ?
            new Result<AlbumFull>(AlbumNotFound) :
            new Result<AlbumFull>(new AlbumFull(album));
    }
}