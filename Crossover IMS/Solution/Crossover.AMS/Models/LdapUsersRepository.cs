using System;
using System.Configuration;
using System.DirectoryServices;
using System.Linq;

namespace Crossover.AMS.Models
{
    public class LdapUsersRepository : IUsersRepository
    {
        private readonly DirectoryEntry _directory;

        public LdapUsersRepository()
        {
            _directory = new DirectoryEntry(ConfigurationManager.AppSettings["LdapDirectoryEntry"]);
        }

        public UserInfo GetUserInfo(string identity)
        {
            if (string.IsNullOrWhiteSpace(identity))
                throw new ArgumentNullException("identity");

            var sections = identity.Split('\\');

            var mySearcher = new DirectorySearcher(_directory)
            {
                Filter = string.Format("(&(objectClass=user)(objectcategory=person)(sAMAccountName={0}))", sections.Last())
            };

            var searchResult = mySearcher.FindAll();
            var res = searchResult[0];

            return new UserInfo(
                (byte[]) res.GetDirectoryEntry().Properties["objectguid"].Value,
                res.GetDirectoryEntry().Properties["sAMAccountName"].Value.ToString(),
                res.GetDirectoryEntry().Properties["cn"].Value.ToString(),
                res.GetDirectoryEntry().Properties["mail"].Value.ToString()
                );
        }
    }
}