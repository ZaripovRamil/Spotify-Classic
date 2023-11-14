using Models.DTO.Light;

namespace SearchAPI.Features.SearchUsers;

public record ResultDto(List<UserLight> Users);