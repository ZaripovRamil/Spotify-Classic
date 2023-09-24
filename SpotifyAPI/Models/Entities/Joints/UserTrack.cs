using Microsoft.EntityFrameworkCore;

namespace Models.Entities.Joints;

[PrimaryKey("Id")]
public class UserTrack
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public DateTime ListenTime { get; set; } = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
    public string UserId { get; set; } = default!;
    public string TrackId { get; set; } = default!;
    public User User { get; set; } = default!;
    public Track Track { get; set; } = default!;

    public UserTrack()
    {
    }

    public UserTrack(User user, Track track)
    {
        UserId = user.Id;
        TrackId = track.Id;
    }
}