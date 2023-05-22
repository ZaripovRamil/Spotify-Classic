using DatabaseServices.Services;
using Models.DTO.BackToFront.Statistics;
using Models.Entities;

namespace AuthAPI.Services;

public class StatisticSnapshotCreator : IStatisticSnapshotCreator
{
    private IDtoCreator _dtoCreator;


    public StatisticSnapshotCreator(IDtoCreator dtoCreator)
    {
        _dtoCreator = dtoCreator;
    }

    public async Task<StatisticSnapshot?> Create(User? user)
    {
        var tracks = user.History
            .Distinct()
            .Select(track => (track, count: user.UserTracks.Count(ut => ut.Track == track)));
        return new StatisticSnapshot
        {
            TotalListens = user.UserTracks.Count,
            Tracks = tracks
                .Select(trackData => new TrackData(_dtoCreator.CreateLight(trackData.track), trackData.count))
                .OrderByDescending(data => data.Count)
                .ToArray(),
            Authors = tracks
                .GroupBy(trackData => trackData.track.Album.Author)
                .Select(authorTracks
                    => new AuthorData(_dtoCreator.CreateLight(authorTracks.Key), authorTracks
                        .Sum(trackData => trackData.count)))
                .OrderByDescending(data => data.Count)
                .ToArray(),
        };
    }
}