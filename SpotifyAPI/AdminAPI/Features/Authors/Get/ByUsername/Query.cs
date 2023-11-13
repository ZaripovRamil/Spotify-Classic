using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Authors.Get.ByUsername;

public record Query(string? Username) : IQuery<IEnumerable<AuthorFull>>;