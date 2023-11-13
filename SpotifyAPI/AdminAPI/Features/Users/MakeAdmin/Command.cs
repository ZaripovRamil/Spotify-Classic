using AdminAPI.Dto;
using Utils.CQRS;

namespace AdminAPI.Features.Users.MakeAdmin;

public record Command(string Login) : ICommand<ResultDto>;