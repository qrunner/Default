using System;

namespace Crossover.AMS.Contracts.Membership
{
    public interface IMembershipProvider
    {
        IMembershipUser CurrentUser { get; }

        IMembershipUser GetUser(string login);

        IMembershipUser GetUser(Guid sid);
    }
}