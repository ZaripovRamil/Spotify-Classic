using Models.DTO.BackToFront;
using Utils.CQRS;

namespace SearchAPI.Features.SearchUsers;

public record Query(string Filter) : IQuery<UsersSearchResult>;