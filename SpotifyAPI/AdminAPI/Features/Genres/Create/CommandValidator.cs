using DatabaseServices.Repositories;
using FluentValidation;
using static Utils.CQRS.Validation.CommonValidationHandlers;
using static Models.ValidationErrors.EntityErrors;

namespace AdminAPI.Features.Genres.Create;

public class CommandValidator : AbstractValidator<Command>
{
    private readonly IGenreRepository _genreRepository;

    public CommandValidator(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;
        
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

        RuleFor(c => c.Name)
            .MustAsync(NotExist)
            .WithMessage(NameTaken);
    }

    private async Task<bool> NotExist(string genreName, CancellationToken cancellationToken = default) =>
        await _genreRepository.GetByNameAsync(genreName) is null;
}