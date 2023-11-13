using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Authors.Get.All;

public record Query : IQuery<IEnumerable<AuthorFull>>;