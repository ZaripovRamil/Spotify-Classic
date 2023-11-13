using Models.DTO.BackToFront.Light;

namespace PlayerAPI.Features.GetPlaylists;

public record ResultDto(List<PlaylistLight> Playlists);