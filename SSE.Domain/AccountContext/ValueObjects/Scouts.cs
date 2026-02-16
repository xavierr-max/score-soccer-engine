namespace SSE.Domain.AccountContext.ValueObjects;

public class Scouts
{
    public Scouts(int goals, int assists)
    {
        Goals = goals;
        Assists = assists;
    }

    public int Goals { get; private set; }
    public int Assists { get; private set; }

    public decimal ToCalculateScore()
    {
        decimal total = 0;

        total += Goals * 8;
        total += Assists * 5;

        return total;
    }

    public void AddGoal()
        => Goals += 1;

    public void AddAssist()
        => Assists += 1;

    public void RemoveGoal()
        => Goals -= 1;

    public void RemoveAssist()
        => Assists -= 1;
}