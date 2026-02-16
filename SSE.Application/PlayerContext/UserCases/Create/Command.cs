using System.Windows.Input;
using ICommand = CartolaAF.Application.Shared.ICommand;

public record Command(string Name, string Last, int Goals, int Assists) : ICommand;