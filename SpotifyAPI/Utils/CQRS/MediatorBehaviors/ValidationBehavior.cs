using FluentValidation;
using MediatR;

namespace Utils.CQRS.MediatorBehaviors;

public class ValidationBehavior<TRequest, TResult> : IPipelineBehavior<TRequest, TResult>
    where TRequest : IRequest<TResult>
    where TResult : Result
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResult> Handle(TRequest request, RequestHandlerDelegate<TResult> next,
        CancellationToken cancellationToken)
    {
        if (!_validators.Any())
            return await next();

        var errors = _validators
            .Select(async validator => await validator.ValidateAsync(request, cancellationToken))
            .SelectMany(result => result.Result.Errors)
            .Select(f => f.ErrorMessage)
            .ToArray();

        if (!errors.Any())
            return await next();

        return GenerateFailedResult(errors);
    }
    
    private static TResult GenerateFailedResult(string[] errors)
    {
        if (typeof(TResult) == typeof(Result))
            return (new Result(errors) as TResult)!;

        var valueType = typeof(TResult).GenericTypeArguments[0];
        var resultGeneric = typeof(Result<>)
            .GetGenericTypeDefinition()
            .MakeGenericType(valueType)
            .GetConstructor(new[] { typeof(string[]) })!
            .Invoke(new object?[] { errors });

        return (TResult)resultGeneric;
    }
}