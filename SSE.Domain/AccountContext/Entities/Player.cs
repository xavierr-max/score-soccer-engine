using SSE.Domain.AccountContext.ValueObjects;
using SSE.Domain.Shared.Entities;

namespace SSE.Domain.AccountContext.Entities;

public class Player : Entity
{
    public Player(Name name, Scouts scouts) 
        : base(Guid.CreateVersion7())
    {
        Name = name;
        Scouts = scouts;
    }

    public Name Name { get; private set; }
    public Scouts Scouts { get; private set; }
    public decimal Punctuation => Scouts.ToCalculateScore();
    
}