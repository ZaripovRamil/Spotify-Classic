using AdminAPI.Dto;
using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Delete;

public record Command(string Id) : ICommand<ResultDto>;