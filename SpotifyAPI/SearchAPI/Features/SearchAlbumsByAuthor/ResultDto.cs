using Models.DTO.BackToFront.Full;

namespace SearchAPI.Features.SearchAlbumsByAuthor;

public record ResultDto(IEnumerable<AlbumFull> Albums);