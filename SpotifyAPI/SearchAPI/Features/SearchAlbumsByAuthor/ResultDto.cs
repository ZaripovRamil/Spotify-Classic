using Models.DTO.Full;

namespace SearchAPI.Features.SearchAlbumsByAuthor;

public record ResultDto(IEnumerable<AlbumFull> Albums);