using Models.DTO.Light;

namespace SearchAPI.Features.SearchAlbums;

public record ResultDto(List<AlbumLight> Albums);