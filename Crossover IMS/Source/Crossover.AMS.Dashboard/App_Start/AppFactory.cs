using Crossover.AMS.Contracts.Membership;
using Crossover.AMS.Membership.Ldap;

namespace Crossover.AMS.Dashboard
{
    public static class AppFactory
    {
        static AppFactory()
        {
            MembershipProvider = new MembershipProvider();
        }

        public static IMembershipProvider MembershipProvider { get; private set; }
    }
}