using Microsoft.EntityFrameworkCore;

namespace Models.Entities.Joints;

[PrimaryKey("Id")]
public class UserTrack
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public DateTime ListenTime { get; set; } = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
    public string UserId { get; set; }
    public string TrackId { get; set; }
    public User User { get; set; }
    public Track Track { get; set; }

    public UserTrack()
    {
    }

    public UserTrack(User user, Track track)
    {
        UserId = user.Id;
        TrackId = track.Id;
    }
}