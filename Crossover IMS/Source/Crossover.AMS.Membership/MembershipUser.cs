using Crossover.AMS.Contracts.Membership;

namespace Crossover.AMS.Membership.Ldap
{
    internal class MembershipUser : IMembershipUser
    {
        public MembershipUser(string sid, string login, string displayName, string email)
        {
            Sid = sid;
            Login = login;
            DisplayName = displayName;
            Email = email;
        }

        public string Sid { get; internal set; }
        public string Login { get; internal set; }
        public string DisplayName { get; internal set; }
        public string Email { get; internal set; }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}