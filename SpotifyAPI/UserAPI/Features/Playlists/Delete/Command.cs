using UserAPI.Dto;
using Utils.CQRS;

namespace UserAPI.Features.Playlists.Delete;

public record Command(string Id, string DeleterId) : ICommand<ResultDto>;