using Models.DTO.BackToFront.Full;

namespace SearchAPI.Features.SearchAuthorsByUser;

public record ResultDto(IEnumerable<AuthorFull> Authors);