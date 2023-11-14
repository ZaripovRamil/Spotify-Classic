using Models.DTO.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Authors.Get.All;

public record Query : IQuery<IEnumerable<AuthorFull>>;