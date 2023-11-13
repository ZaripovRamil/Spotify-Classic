using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Authors.Get.ById;

public record Query(string Id) : IQuery<AuthorFull>;