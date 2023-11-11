using Models.DTO.BackToFront.Light;

namespace SearchAPI.Features.SearchUsers;

public record ResultDto(List<UserLight> Users);