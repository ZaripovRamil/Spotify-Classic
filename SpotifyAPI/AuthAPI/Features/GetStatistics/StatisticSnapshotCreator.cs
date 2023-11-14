using AuthAPI.Features.GetStatistics.Dto;
using DatabaseServices;
using Models.Entities;

namespace AuthAPI.Features.GetStatistics;

public class StatisticSnapshotCreator : IStatisticSnapshotCreator
{
    private readonly IDtoCreator _dtoCreator;

    public StatisticSnapshotCreator(IDtoCreator dtoCreator)
    {
        _dtoCreator = dtoCreator;
    }

    public Task<StatisticSnapshot> Create(User? user)
    {
        var tracks = user!.History
            .Distinct()
            .Select(track => (track, count: user.UserTracks.Count(ut => ut.Track == track)));
        var trackCounts = tracks.ToList();
        var genres = trackCounts.SelectMany(t => t.track.Genres).Distinct();
        var dict = genres.ToDictionary(g => g, _ => 0); // genre can be null here?
        foreach (var genreList in trackCounts.Select(t => t.track.Genres))
        {
            foreach (var genre in genreList)
                dict[genre] += 1;
        }

        return Task.FromResult(new StatisticSnapshot
        {
            TotalListens = user.UserTracks.Count,
            Tracks = trackCounts
                .Select(trackData => new TrackData(_dtoCreator.CreateLight(trackData.track)!, trackData.count))
                .OrderByDescending(data => data.Count)
                .ToArray(),
            Authors = trackCounts
                .GroupBy(trackData => trackData.track.Album.Author)
                .Select(authorTracks
                    => new AuthorData(_dtoCreator.CreateLight(authorTracks.Key)!, authorTracks
                        .Sum(trackData => trackData.count)))
                .OrderByDescending(data => data.Count)
                .ToArray(),
            Genres = dict.Select(pair => new GenreData(_dtoCreator.CreateLight(pair.Key)!, pair.Value))
                .OrderByDescending(data => data.Count)
                .ToArray()
        });
    }
}