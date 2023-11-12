using DatabaseServices.Repositories;
using FluentValidation;
using static Models.Entities.ValidationErrors.AuthorErrors;

namespace AdminAPI.Features.Authors.Delete;

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
        RuleFor(c => c.Id)
            .MustAsync(Exist)
            .WithMessage(AuthorNotFound);

        RuleFor(c => c.Id)
            .MustAsync(NotHaveAlbums)
            .WithMessage(AuthorHasAlbums);
    }

    private async Task<bool> Exist(string id, CancellationToken cancellationToken) =>
        await _authorRepository.GetByIdAsync(id) is not null;
    
    private async Task<bool> NotHaveAlbums(string id, CancellationToken cancellationToken) =>
        await _authorRepository.GetByIdAsync(id) is not null;
}