using DatabaseServices.Repositories;
using FluentValidation;
using static Utils.CQRS.Validation.CommonValidationHandlers;
using static Models.ValidationErrors.EntityErrors;
using static Models.ValidationErrors.TrackErrors;
using static Models.ValidationErrors.AlbumErrors;

namespace AdminAPI.Features.Tracks.Create;

public class CommandValidator : AbstractValidator<Command>
{
    private readonly IGenreRepository _genreRepository;
    private readonly IAlbumRepository _albumRepository;

    public CommandValidator(IGenreRepository genreRepository, IAlbumRepository albumRepository)
    {
        _genreRepository = genreRepository;
        _albumRepository = albumRepository;

        RegisterRules();
    }

    private void RegisterRules()
    {
        RuleFor(c => c.Name)
            .Must(BeNotNullNotEmpty)
            .WithMessage(FieldEmpty(nameof(Command.Name)));
        
        RuleFor(c => c.Name)
            .Must(ContainOnlyAllowedCharacters)
            .WithMessage(FieldContainsUnacceptableCharacters(nameof(Command.Name)));

        RuleFor(c => c.AlbumId)
            .MustAsync(ExistAlbum)
            .WithMessage(AlbumNotFound);

        RuleFor(c => c.GenreIds)
            .MustAsync(ExistGenres)
            .WithMessage(InvalidGenre);

        RuleFor(c => c.TrackFile)
            .Must(p => p.Length > 0)
            .WithMessage(InvalidTrackFile);
    }

    private async Task<bool> ExistAlbum(string albumId, CancellationToken cancellationToken = default) =>
        await _albumRepository.GetByIdAsync(albumId) is not null;
    
    private async Task<bool> ExistGenres(string[] genreIds, CancellationToken cancellationToken = default)
    {
        foreach (var genreId in genreIds)
            if (await _genreRepository.GetByIdAsync(genreId) is null)
                return false;

        return true;
    }
}