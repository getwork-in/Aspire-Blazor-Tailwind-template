﻿using MediatR;

namespace BlazorApp7.Domain.BuildingBlocks;

public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand>
	where TCommand : ICommand
{
}

public interface ICommandHandler<in TCommand, TResult> : IRequestHandler<TCommand, TResult>
	where TCommand : ICommand<TResult>
{
}

