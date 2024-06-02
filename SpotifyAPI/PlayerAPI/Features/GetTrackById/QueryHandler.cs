using System.Security.Claims;
using System.Text.RegularExpressions;
using DatabaseServices.Repositories;
using Microsoft.Extensions.Options;
using Models.Configuration;
using Models.DTO.Full;
using Models.Entities;
using Models.MessagingContracts;
using Utils.Clickhouse;
using Utils.CQRS;
using Utils.RabbitMq;

namespace PlayerAPI.Features.GetTrackById;

public class QueryHandler : IQueryHandler<Query, Stream>
{
    private static Regex TrackIdRegex() =>
        new("^[a-zA-Z0-9_.-]+$", RegexOptions.Compiled, TimeSpan.FromMilliseconds(500));

    private readonly ITrackRepository _trackRepository;
    private readonly IUserRepository _userRepository;
    private readonly HttpClient _clientToStatic;
    private readonly IRabbitMqService _rabbitMqService;
    private readonly IClickHouseService _clickHouseService;

    public QueryHandler(ITrackRepository trackRepository, IUserRepository userRepository, IOptions<Hosts> hostsOptions,
        IRabbitMqService rabbitMqService, IClickHouseService clickHouseService)
    {
        _trackRepository = trackRepository;
        _userRepository = userRepository;
        _rabbitMqService = rabbitMqService;
        _clickHouseService = clickHouseService;

        _clientToStatic = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.StaticApi}/tracks/") };
    }

    public async Task<Result<Stream>> Handle(Query request, CancellationToken cancellationToken)
    {
        if (!TrackIdRegex().IsMatch(request.Id)) return new Result<Stream>("Error");
        if (request.Id.EndsWith(".ts")) // if file.ts requested, not track
            return await StreamTrack(request.Id);
        var trackInfo = await GetTrackInfo(request.Id);
        if (trackInfo is null)
            return new Result<Stream>("Error");
        await AddTrackToHistory(request.Id, request.User);
        await _clickHouseService.InsertListenAsync(new TrackListen { TrackId = request.Id, ListenCount = 1 });
        SendListenEvent(trackInfo.Album.Id, request.Id);
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
        if (user != null && track != null) await _userRepository.AddTrackToHistoryAsync(user, track);
    }

    private void SendListenEvent(string albumId, string trackId, int count = 1)
    {
        var listenEvent = new ListenEvent(trackId, count);
        _rabbitMqService.PublishMessage(RabbitMqConstants.GetListenQueue(albumId), albumId, listenEvent);
    }
}