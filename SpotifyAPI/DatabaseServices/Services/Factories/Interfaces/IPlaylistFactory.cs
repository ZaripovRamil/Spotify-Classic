using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface IPlaylistFactory
{
    public Task<(PlaylistValidationCode, Playlist?)> Create(PlaylistCreationData data);
}