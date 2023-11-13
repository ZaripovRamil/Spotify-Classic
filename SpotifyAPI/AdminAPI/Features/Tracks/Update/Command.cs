using AdminAPI.Dto;
using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Update;

public record Command(string Id, string Name) : ICommand<ResultDto>;