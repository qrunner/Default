using System.Web;

namespace Crossover.AMS.Models
{
    public static class ApplicationRoots
    {
        private const string Usersmanager = "usersManager";

        public static UsersManager UsersManager
        {
            get
            {
                lock (Usersmanager)
                {
                    if (HttpContext.Current.Application[Usersmanager] == null)
                    {
                        IUsersRepository usersRepository = new LdapUsersRepository();
                        HttpContext.Current.Application.Add(Usersmanager, new UsersManager(usersRepository));
                    }
                    return (UsersManager) HttpContext.Current.Application[Usersmanager];
                }
            }
        }
    }
}