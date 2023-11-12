using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.UpdatePassword;

public record Command(PasswordUpdateData Data, User? User) : ICommand;