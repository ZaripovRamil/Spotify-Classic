using AdminAPI.Dto;
using Utils.CQRS;

namespace AdminAPI.Features.Authors.Delete;

public record Command(string Id) : ICommand<ResultDto>;