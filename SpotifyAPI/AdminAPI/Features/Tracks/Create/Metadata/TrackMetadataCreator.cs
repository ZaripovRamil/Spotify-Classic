using AdminAPI.Services;
using DatabaseServices.Repositories;
using Models.Metadata;
using NAudio.Wave;
using Utils.CQRS;
using Utils.CQRS.ServiceDefinition;

namespace AdminAPI.Features.Tracks.Create.Metadata;

[ServiceDefinition(ServiceLifetime.Scoped)]
public class TrackMetadataCreator: IMetadataCreator<Command,TrackMetadata>
{
    private readonly IAlbumRepository _albumRepository;
    public TrackMetadataCreator(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }
    public async Task<Result<TrackMetadata>> CreateMetadata(Command item)
    {
        await using var stream = item.TrackFile.OpenReadStream();
        await using var mp3Reader = new Mp3FileReader(stream);
        var duration = mp3Reader.TotalTime;
        var durationInSeconds = (uint)duration.TotalSeconds;
        stream.Position = 0;
        
        var album = await _albumRepository.GetByIdAsync(item.AlbumId);
        var author = album?.Author;
        
        return new Result<TrackMetadata>(new TrackMetadata(item.FileId, item.TrackFile.FileName, item.TrackFile.Length,
            durationInSeconds, item.Name, album!.Name, author!.Name,
            item.TrackId!, album.Id, author.Id));
    }
}