using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.UpdateUsername;

public record Command(string Username, User? User) : ICommand;