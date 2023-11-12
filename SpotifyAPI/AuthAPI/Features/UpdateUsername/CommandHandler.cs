using Microsoft.AspNetCore.Identity;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.UpdateUsername;

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
        if (!ValidateUsername(request.Username))
        {
            res.Fail();
            res.AddErrors("Invalid username");
        }

        request.User!.Name = request.Username;
        if (!(await _userManager.UpdateAsync(request.User)).Succeeded)
        {
            res.Fail();
            res.AddErrors("Failed to update username");
        }

        return res;
    }

    private static bool ValidateUsername(string username)
    {
        return username.All(char.IsLetterOrDigit) && username.Length >= 4;
    }
}