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

    private async Task<bool> Exist(Guid id, CancellationToken cancellationToken) =>
        await _albumRepository.GetByIdAsync(id.ToString()) is not null;

    private async Task<bool> NotContainTracks(Guid id, CancellationToken cancellationToken) =>
        (await _albumRepository.GetByIdAsync(id.ToString()))!.Tracks.Count == 0;
}