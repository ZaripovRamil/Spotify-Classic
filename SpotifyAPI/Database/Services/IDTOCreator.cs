using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;
using Models.Entities;

namespace Database.Services;

public interface IDtoCreator
{
    AlbumFull? CreateFull(Album? getById);
    AuthorFull? CreateFull(Author? getById);
    GenreLight? CreateLight(Genre? getById);
    TrackFull? CreateFull(Track? getById);
    UserFull? CreateFull(User? getByUsername);
    PlaylistFull? CreateFull(Playlist? get);
}