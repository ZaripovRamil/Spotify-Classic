using DatabaseServices.Repositories;
using Models.Entities;
using Utils.CQRS;
using static Models.ValidationErrors.CommonConstants;

namespace AdminAPI.Features.Genres.Create;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IGenreRepository _genreRepository;

    public CommandHandler(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var genre = new Genre(request.Name);
        await _genreRepository.AddAsync(genre);
        return new ResultDto(true, Successful, genre.Id);
    }
}