using Models.DTO.FrontToBack;

namespace Models.DTO;

public class PlaylistTrackOperationDataWithUser : PlaylistTrackOperationData
{
    public string UserName { get; set; }

    public PlaylistTrackOperationDataWithUser(PlaylistTrackOperationData data, string userName)
    {
        TrackId = data.TrackId;
        UserName = userName;
        PlaylistId = data.PlaylistId;
    }

    public PlaylistTrackOperationDataWithUser()
    {
    }
}