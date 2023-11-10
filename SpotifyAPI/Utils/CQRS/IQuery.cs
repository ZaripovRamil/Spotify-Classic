using MediatR;

namespace Utils.CQRS;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}