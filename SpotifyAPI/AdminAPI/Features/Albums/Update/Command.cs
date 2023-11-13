using AdminAPI.Dto;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Update;

public record Command(string Id, string Name) : ICommand<ResultDto>;