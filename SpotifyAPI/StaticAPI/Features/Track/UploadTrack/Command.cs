using StaticAPI.Dto;
using StaticAPI.Dto.FileDataDTO;
using Utils.CQRS;

namespace StaticAPI.Features.Track.UploadTrack;

public record Command(TrackDataDto? Data) : ICommand<ResultDto>;