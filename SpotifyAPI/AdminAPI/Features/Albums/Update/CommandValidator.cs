using DatabaseServices.Repositories;
using FluentValidation;
using static Utils.CQRS.Validation.CommonValidationHandlers;
using static Models.Entities.ValidationErrors.EntityErrors;
using static Models.Entities.ValidationErrors.AlbumErrors;

namespace AdminAPI.Features.Albums.Update;

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
        RuleFor(c => c.Name)
            .Must(BeNotNullNotEmpty)
            .WithMessage(FieldEmpty(nameof(Create.Command.Name)));
        
        RuleFor(c => c.Name)
            .Must(ContainOnlyAllowedCharacters)
            .WithMessage(FieldContainsUnacceptableCharacters(nameof(Command.Name)));

        RuleFor(c => c.Id)
            .MustAsync(Exist)
            .WithMessage(AlbumNotFound);
    }

    private async Task<bool> Exist(string albumId, CancellationToken cancellationToken = default) =>
        await _albumRepository.GetByIdAsync(albumId) is not null;
}