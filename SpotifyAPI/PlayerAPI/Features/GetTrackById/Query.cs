using System.Security.Claims;
using Utils.CQRS;

namespace PlayerAPI.Features.GetTrackById;

public record Query(string Id, ClaimsPrincipal User) : IQuery<Stream>;