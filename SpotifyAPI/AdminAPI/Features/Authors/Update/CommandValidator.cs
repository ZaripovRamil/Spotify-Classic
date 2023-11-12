using DatabaseServices.Repositories;
using FluentValidation;
using static Utils.CQRS.Validation.CommonValidationHandlers;
using static Models.Entities.ValidationErrors.EntityErrors;
using static Models.Entities.ValidationErrors.AuthorErrors;

namespace AdminAPI.Features.Authors.Update;

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
            .WithMessage(FieldEmpty(nameof(Create.Command.Name)));
        
        RuleFor(c => c.Name)
            .Must(ContainOnlyAllowedCharacters)
            .WithMessage(FieldContainsUnacceptableCharacters(nameof(Command.Name)));

        RuleFor(c => c.Id)
            .MustAsync(Exist)
            .WithMessage(AuthorNotFound);
    }

    private async Task<bool> Exist(string authorId, CancellationToken cancellationToken = default) =>
        await _authorRepository.GetByIdAsync(authorId) is not null;
}