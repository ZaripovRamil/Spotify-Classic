using Utils.CQRS;

namespace UserAPI.Features.Playlists.Create;

public record Command(string Name, string OwnerId) : ICommand<ResultDto>;