using DatabaseServices.Repositories;
using Utils.CQRS;
using static Utils.CQRS.Validation.CommonValidationHandlers;
using static Models.ValidationErrors.EntityErrors;
using static Models.ValidationErrors.AlbumErrors;

namespace AdminAPI.Features.Albums.Create.AlbumSavers;

public class DbValidator
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IAlbumRepository _albumRepository;

    public DbValidator(IAuthorRepository authorRepository, IAlbumRepository albumRepository)
    {
        _authorRepository = authorRepository;
        _albumRepository = albumRepository;
    }

    public async Task<Result> ValidateAsync(Command item)
    {
        var result = new Result();
        if (!BeNotNullNotEmpty(item.Name))
            result.AddErrors(FieldEmpty(nameof(Command.Name)));
        if (!ContainOnlyAllowedCharacters(item.Name))
            result.AddErrors(FieldContainsUnacceptableCharacters(nameof(Command.Name)));
        if (item.ReleaseYear < 0 || item.ReleaseYear > DateTime.Now.Year)
            result.AddErrors(InvalidReleaseYear);
        if (await _authorRepository.GetByIdAsync(item.AuthorId) is null)
            result.AddErrors(AuthorNotFound);
        if (await _albumRepository.GetByIdAsync(item.Id) is not null)
            result.AddErrors(AlreadyExists);
        return result;
    }
}