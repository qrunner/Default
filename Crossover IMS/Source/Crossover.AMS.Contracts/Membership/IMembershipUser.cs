namespace Crossover.AMS.Contracts.Membership
{
    public interface IMembershipUser
    {
        string Sid { get; }

        string Login { get; }

        string DisplayName { get; }

        string Email { get; }
    }
}