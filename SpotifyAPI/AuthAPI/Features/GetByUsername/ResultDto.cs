using Models.DTO.Full;
using Models.DTO.Light;
using OneOf;

namespace AuthAPI.Features.GetByUsername;

public record ResultDto(OneOf<UserFull?, UserLight?> UserDto);