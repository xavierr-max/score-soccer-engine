namespace SSE.Domain.AccountContext.ValueObjects;

public class Name
{
    public Name(string firstName, string lastName)
    {
        if (string.IsNullOrEmpty(firstName))
            throw new ArgumentException("O Primeiro nome é obrigatório");

        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public static implicit operator string(Name name)
        => name.ToString();

    public override string ToString()
        => $"{FirstName} {LastName}";
}