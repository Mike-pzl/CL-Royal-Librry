using CLRL.Domain.Abstractions;
using MediatR;

namespace CLRL.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
