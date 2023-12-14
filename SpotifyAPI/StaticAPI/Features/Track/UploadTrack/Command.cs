using Models.DTO.FileDataDTO;
using StaticAPI.Dto;
using Utils.CQRS;

namespace StaticAPI.Features.Track.UploadTrack;

public record Command (TrackDataDto? Data) : ICommand<ResultDto>;