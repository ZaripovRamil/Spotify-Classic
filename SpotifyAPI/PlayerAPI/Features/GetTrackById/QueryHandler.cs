using System.Security.Claims;
using System.Text.RegularExpressions;
using DatabaseServices.Repositories;
using Microsoft.Extensions.Options;
using Models.Configuration;
using Models.DTO.Full;
using Utils.CQRS;

namespace PlayerAPI.Features.GetTrackById;

public partial class QueryHandler: IQueryHandler<Query, Stream>
{  
    private readonly ITrackRepository _trackRepository;
    private readonly IUserRepository _userRepository;
    private readonly HttpClient _clientToStatic;

    public QueryHandler(ITrackRepository trackRepository,IUserRepository userRepository, IOptions<Hosts> hostsOptions)
    {
        _trackRepository = trackRepository;
        _userRepository = userRepository;
        
        _clientToStatic = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.StaticApi}/tracks/") };
    }
    
    public async Task<Result<Stream>> Handle(Query request, CancellationToken cancellationToken)
    {
        if (!TrackIdRegex().IsMatch(request.Id)) return  new Result<Stream>("Error");
        if (request.Id.EndsWith(".ts")) // if file.ts requested, not track
            return await StreamTrack(request.Id);
        var trackInfo = await GetTrackInfo(request.Id);
        if (trackInfo is null)
            return  new Result<Stream>("Error");
        await AddTrackToHistory(request.Id, request.User);
        return await StreamTrack(trackInfo.FileId);
    }
    
    private async Task<TrackFull?> GetTrackInfo(string trackId)
    {
        var track = await _trackRepository.GetByIdAsync(trackId);
        return track is null ? null : new TrackFull(track);
    }

    private async Task<Result<Stream>> StreamTrack(string fileId)
    {
        try
        {
            var responseStream = await _clientToStatic.GetStreamAsync(fileId);
            return new Result<Stream>(responseStream);
        }
        catch (HttpRequestException)
        {
            return new Result<Stream>("Error");
        }
    }
    
    private async Task AddTrackToHistory(string trackId, ClaimsPrincipal userClaimsPrincipal)
    {
        var userName = userClaimsPrincipal.Identity?.Name!;
        var user = await _userRepository.GetByNameAsync(userName);
        var track = await _trackRepository.GetByIdAsync(trackId);
        if (user != null && track != null)  await _userRepository.AddTrackToHistoryAsync(user, track);
    }
    
    [GeneratedRegex("^[a-zA-Z0-9_.-]+$", default, 500)]
    private static partial Regex TrackIdRegex();
}