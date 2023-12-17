using FluentValidation;
using static Models.ValidationErrors.EntityErrors;

namespace StaticAPI.Features.Track.UploadTrack;

public class CommandValidator : AbstractValidator<Command>
{
    public CommandValidator()
    {
        RegisterRules();
    }

    private void RegisterRules()
    {
        RuleFor(c => c.Data).Must((_, dto) => dto is not null)
            .WithMessage(FieldEmpty(nameof(Command.Data)));
    }
}