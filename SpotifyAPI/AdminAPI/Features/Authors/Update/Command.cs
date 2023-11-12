using AdminAPI.Dto;
using Utils.CQRS;

namespace AdminAPI.Features.Authors.Update;

public record Command(string Id, string Name) : ICommand<ResultDto>;