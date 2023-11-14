using Models.DTO.Full;

namespace SearchAPI.Features.SearchAuthorsByUser;

public record ResultDto(IEnumerable<AuthorFull> Authors);