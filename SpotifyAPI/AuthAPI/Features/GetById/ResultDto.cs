using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;
using OneOf;

namespace AuthAPI.Features.GetById;

public record ResultDto(OneOf<UserFull?, UserLight?> UserDto);