using Utils.CQRS;

namespace AdminAPI.Features.Genres.Create;

public record Command(string Name) : ICommand<ResultDto>;