using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;
using Models.Entities;

namespace Database.Services;

public class DtoCreator : IDtoCreator
{
    public AlbumFull? CreateFull(Album? album)
    {
        return album == null ? null : new AlbumFull(album);
    }

    public AuthorFull? CreateFull(Author? author)
    {
        return author == null ? null : new AuthorFull(author);
    }

    public GenreLight? CreateLight(Genre? genre)
    {
        return genre == null ? null : new GenreLight(genre);
    }

    public TrackFull? CreateFull(Track? track)
    {
        return track == null ? null : new TrackFull(track);
    }

    public UserFull? CreateFull(User? user)
    {
        return user == null ? null : new UserFull(user);
    }

    public PlaylistFull? CreateFull(Playlist? playlist)
    {
        return playlist == null ? null : new PlaylistFull(playlist);
    }
}