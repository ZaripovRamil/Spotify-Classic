using Models.Entities;
using UserAPI.Dto;
using Utils.CQRS;

namespace UserAPI.Features.Playlists.Update;

public record Command(string PlaylistId, string Name, string PreviewId, string UpdaterUserId) : ICommand<ResultDto>;