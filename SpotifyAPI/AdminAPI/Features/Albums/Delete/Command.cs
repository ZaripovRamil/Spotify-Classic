using AdminAPI.Dto;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Delete;

public record Command(Guid Id) : ICommand<ResultDto>;