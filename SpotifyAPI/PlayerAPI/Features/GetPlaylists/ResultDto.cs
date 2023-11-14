using Models.DTO.Light;

namespace PlayerAPI.Features.GetPlaylists;

public record ResultDto(List<PlaylistLight> Playlists);