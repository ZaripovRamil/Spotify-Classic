using AdminAPI.Services;
using DatabaseServices.Repositories;
using Models.Metadata;
using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Create.Metadata;

public class TrackMetadataCreator: IMetadataCreator<Command,TrackMetadata>
{
    private readonly IAlbumRepository _albumRepository;
    public TrackMetadataCreator(IAlbumRepository albumRepository, IAuthorRepository authorRepository)
    {
        _albumRepository = albumRepository;
    }
    public async Task<Result<TrackMetadata>> CreateMetadata(Command item)
    {
        var album = await _albumRepository.GetByIdAsync(item.AlbumId);
        var author = album?.Author;
        return new Result<TrackMetadata>(new TrackMetadata(1, item.FileId, item.TrackFile.FileName,
            item.TrackFile.Length,
            item.Name, album!.Name, author!.Name,
            "1", album.Id, author.Id));
    }
}