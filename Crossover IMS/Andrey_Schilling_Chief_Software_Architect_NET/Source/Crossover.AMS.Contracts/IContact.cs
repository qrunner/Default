namespace Crossover.AMS.Contracts
{
    public interface IContact
    {
        ContactCategory Category { get; }

        ContactType Type { get; }

        string Value { get; }
    }
}