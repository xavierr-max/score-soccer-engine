using CartolaAF.Application.PlayerContext.UserCases.Create;
using CartolaAF.Application.Shared;
using SSE.Domain.AccountContext.Entities;
using SSE.Domain.AccountContext.ValueObjects;

namespace SSE.Application.PlayerContext.UserCases.Create;

public class Handler : IHandler<Command, Response>
{
    public async Task<Response> Handle(Command command)
    {
        await Task.Delay(10);

        var playerName = new Name(command.Name, command.Last);
        var playerScores = new Scouts(command.Goals, command.Assists);
        var player = new Player(playerName, playerScores);

        return new Response(
            $"Nome do jogador é {player.Name}, fez {player.Scouts.Goals} gols e {player.Scouts.Assists} assistencias. A pontuacao da rodada foi de {player.Scouts.ToCalculateScore()}");
        
    }
}