using Models.DTO.BackToFront.Light;

namespace PlayerAPI.Features.GetAlbums;

public record ResultDto(List<AlbumLight> Albums);