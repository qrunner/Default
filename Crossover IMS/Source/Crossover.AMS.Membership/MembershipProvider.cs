using System;
using System.Configuration;
using System.DirectoryServices;
using System.Linq;
using System.Security.Principal;
using Crossover.AMS.Contracts.Membership;

namespace Crossover.AMS.Membership.Ldap
{
    public class MembershipProvider : IMembershipProvider
    {
        private readonly DirectoryEntry _directory;

        public MembershipProvider()
        {
            _directory = new DirectoryEntry(ConfigurationManager.AppSettings["LdapDirectoryEntry"]);
        }

        public IMembershipUser CurrentUser
        {
            get { return GetUser(WindowsIdentity.GetCurrent().Name); }
        }

        public IMembershipUser GetUser(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentNullException("login");

            var sections = login.Split('\\');

            var mySearcher = new DirectorySearcher(_directory) { Filter = string.Format("(&(objectClass=user)(objectcategory=person)(sAMAccountName={0}))", sections.Last()) };

            var searchResult = mySearcher.FindAll();

            if (searchResult.Count == 0)
            {
                return new MembershipUser(login, "Undefined", "Undefined", "");
            }

            var res = searchResult[0];

            return new MembershipUser(
                res.GetDirectoryEntry().Properties["sAMAccountName"].Value.ToString(), //(byte[])res.GetDirectoryEntry().Properties["objectguid"].Value,
                res.GetDirectoryEntry().Properties["sAMAccountName"].Value.ToString(),
                res.GetDirectoryEntry().Properties["cn"].Value.ToString(),
                res.GetDirectoryEntry().Properties["mail"].Value.ToString()
                );
        }

        /*private MembershipUser SearchUser(string filter)
        {
            var mySearcher = new DirectorySearcher(_directory) {Filter = filter};

            var searchResult = mySearcher.FindAll();

            if (searchResult.Count == 0)
            {
                return new MembershipUser(new byte[16], "Undefined", "Undefined", "");
            }

            var res = searchResult[0];

            return new MembershipUser(
                res.GetDirectoryEntry().Properties["sAMAccountName"].Value.ToString(), //(byte[])res.GetDirectoryEntry().Properties["objectguid"].Value,
                res.GetDirectoryEntry().Properties["sAMAccountName"].Value.ToString(),
                res.GetDirectoryEntry().Properties["cn"].Value.ToString(),
                res.GetDirectoryEntry().Properties["mail"].Value.ToString()
                );
        }*/

        public IMembershipUser GetUser(Guid sid)
        {
            throw new NotImplementedException();
        }
    }
}