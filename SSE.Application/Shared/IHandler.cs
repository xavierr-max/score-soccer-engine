using CartolaAF.Application.PlayerContext.UserCases.Create;

namespace CartolaAF.Application.Shared;

public interface IHandler<TCommand, TResponse>
    where TCommand : ICommand
    where TResponse : IResponse
{
    Task<TResponse> Handle(TCommand command);
}