using Models.DTO.BackToFront.Light;

namespace SearchAPI.Features.SearchAlbums;

public record ResultDto(List<AlbumLight> Albums);