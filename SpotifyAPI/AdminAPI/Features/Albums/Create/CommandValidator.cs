using DatabaseServices.Repositories;
using FluentValidation;
using static Utils.CQRS.Validation.CommonValidationHandlers;
using static Models.ValidationErrors.EntityErrors;
using static Models.ValidationErrors.AlbumErrors;

namespace AdminAPI.Features.Albums.Create;

public class CommandValidator : AbstractValidator<Command>
{
    private readonly IAuthorRepository _authorRepository;
    
    public CommandValidator(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
        
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

        RuleFor(c => c.ReleaseYear)
            .InclusiveBetween(0, DateTime.Now.Year)
            .WithMessage(InvalidReleaseYear);

        RuleFor(c => c.AuthorId)
            .MustAsync(Exist)
            .WithMessage(AuthorNotFound);

        RuleFor(c => c.PreviewImage)
            .Must(p => p.Length > 0)
            .WithMessage(InvalidPreview);
    }

    private async Task<bool> Exist(string authorId, CancellationToken cancellationToken = default) =>
        await _authorRepository.GetByIdAsync(authorId) is not null;
}