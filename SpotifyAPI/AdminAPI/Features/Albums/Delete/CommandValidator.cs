using DatabaseServices.Repositories;
using FluentValidation;
using static Models.Entities.ValidationErrors.AlbumErrors;

namespace AdminAPI.Features.Albums.Delete;

public class CommandValidator : AbstractValidator<Command>
{
    private readonly IAlbumRepository _albumRepository;

    public CommandValidator(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
        
        RegisterRules();
    }

    private void RegisterRules()
    {
        RuleFor(c => c.Id)
            .MustAsync(Exist)
            .WithMessage(AlbumNotFound);

        RuleFor(c => c.Id)
            .MustAsync(NotContainTracks)
            .WithMessage(AlbumContainsTracks);
    }

    private async Task<bool> Exist(string id, CancellationToken cancellationToken) =>
        await _albumRepository.GetByIdAsync(id) is not null;

    private async Task<bool> NotContainTracks(string id, CancellationToken cancellationToken) =>
        (await _albumRepository.GetByIdAsync(id))!.Tracks.Count == 0;
}