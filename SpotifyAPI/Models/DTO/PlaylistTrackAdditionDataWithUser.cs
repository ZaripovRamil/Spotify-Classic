using Models.DTO.FrontToBack;

namespace Models.DTO;

public class PlaylistTrackAdditionDataWithUser : PlaylistTrackAdditionData
{
    public string UserName { get; set; }

    public PlaylistTrackAdditionDataWithUser(PlaylistTrackAdditionData data, string userName)
    {
        TrackId = data.TrackId;
        UserName = userName;
        PlaylistId = data.PlaylistId;
    }

    public PlaylistTrackAdditionDataWithUser()
    {
    }
}