using External.Redis;
using StackExchange.Redis;
using StaticAPI.Services.Interfaces;

namespace StaticAPI.Features.Track.UploadTrack;

public class RedisClearingService : BackgroundService
{
    private readonly TimeSpan _idlePeriod = TimeSpan.FromDays(1);
    private readonly IFileProcessingService _fileProcessingService;

    public RedisClearingService(IFileProcessingService fileProcessingService)
    {
        _fileProcessingService = fileProcessingService;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await _fileProcessingService.ClearRedis(stoppingToken);
            await Task.Delay(_idlePeriod, stoppingToken);
        }
    }
}