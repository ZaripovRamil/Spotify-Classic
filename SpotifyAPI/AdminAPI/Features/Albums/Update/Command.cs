using AdminAPI.Dto;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Update;

public record Command(Guid Id, string Name) : ICommand<ResultDto>;