using MediatR;

namespace BlazorApp7.GMS.BuildingBlocks;

public interface ICommand : IRequest
{
}

public interface ICommand<out TResult> : IRequest<TResult>
{
}
