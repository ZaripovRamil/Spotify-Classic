using Models.DTO.Light;

namespace PlayerAPI.Features.GetAlbums;

public record ResultDto(List<AlbumLight> Albums);