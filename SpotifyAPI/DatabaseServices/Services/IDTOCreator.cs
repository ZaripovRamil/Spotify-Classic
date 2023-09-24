﻿using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;
using Models.Entities;

namespace DatabaseServices.Services;

public interface IDtoCreator
{
    AlbumFull? CreateFull(Album? album);
    AuthorFull? CreateFull(Author? author);
    TrackFull? CreateFull(Track? track);
    UserFull? CreateFull(User? user);
    PlaylistFull? CreateFull(Playlist? playlist);
    GenreLight? CreateLight(Genre? genre);
    UserLight? CreateLight(User? user);
    AuthorLight? CreateLight(Author author);
    TrackLight? CreateLight(Track track);
}