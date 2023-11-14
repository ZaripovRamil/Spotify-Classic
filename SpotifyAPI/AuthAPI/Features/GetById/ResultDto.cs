using Models.DTO.Full;
using Models.DTO.Light;
using OneOf;

namespace AuthAPI.Features.GetById;

public record ResultDto(OneOf<UserFull?, UserLight?> UserDto);