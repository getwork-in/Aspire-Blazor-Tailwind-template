using MediatR;

namespace BlazorApp7.Domain.BuildingBlocks;

public interface ICommand : IRequest
{
}

public interface ICommand<out TResult> : IRequest<TResult>
{
}
