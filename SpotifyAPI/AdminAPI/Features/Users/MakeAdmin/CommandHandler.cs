using AdminAPI.Dto;
using DatabaseServices.Repositories;
using Models.Entities.Enums;
using Utils.CQRS;

namespace AdminAPI.Features.Users.MakeAdmin;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IUserRepository _userRepository;

    public CommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByNameAsync(request.Login);
        await _userRepository.SetRoleAsync(user!, Role.Admin);
        return new ResultDto(true, "Successful");
    }
}