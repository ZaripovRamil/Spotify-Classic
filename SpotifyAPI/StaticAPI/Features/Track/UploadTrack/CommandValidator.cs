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
        RuleFor(c => c.Data)
            .Must((command, dto) => dto != null)
            .WithMessage(FieldEmpty(nameof(Command.Data)));
        RuleFor(c => c.Data!.File)
            .Must((command, file) => file != null && file.Length != 0)
            .WithMessage(FieldEmpty(nameof(Command.Data.File)));
        RuleFor(c => c.Data!.File!.FileName)
            .Must((command, name) => !string.IsNullOrEmpty(name))
            .WithMessage(FieldEmpty(nameof(Command.Data.File.FileName)));
        RuleFor(c => c.Data!.TrackMetadata)
            .Must((command, metadata) => metadata != null)
            .WithMessage(FieldEmpty(nameof(Command.Data.File)));
    }
}