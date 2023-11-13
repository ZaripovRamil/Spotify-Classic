using Microsoft.AspNetCore.Identity;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.UpdatePassword;

public class CommandHandler : ICommandHandler<Command>
{
    private readonly UserManager<User> _userManager;

    public CommandHandler(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task<Result> Handle(Command request, CancellationToken cancellationToken)
    {
        var res = new Result();
        var updateData = request.Data;

        if ((await _userManager.ChangePasswordAsync(request.User!, updateData.OldPassword, updateData.Password))
            .Succeeded) return res;
        
        res.Fail();
        res.AddErrors("Failed to update password");
        return res;
    }
}