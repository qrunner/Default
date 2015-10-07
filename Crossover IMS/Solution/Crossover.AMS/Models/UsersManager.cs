using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Web;

namespace Crossover.AMS.Models
{
    public class UsersManager
    {
        private Timer _timer;
        private const int RefreshInterval = 300000;
        private readonly IUsersRepository _usersRepository;

        public UsersManager(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
            _timer = new Timer(RemoveOffline, null, RefreshInterval, RefreshInterval);
        }

        private readonly ConcurrentDictionary<string, UserInfo> _usersOnline = new ConcurrentDictionary<string, UserInfo>();

        public IEnumerable<UserInfo> UsersOnline
        {
            get { return _usersOnline.Values; }
        }

        public UserInfo CurrentUser
        {
            get
            {
                var identity = HttpContext.Current.User.Identity.Name;

                var user = _usersOnline.GetOrAdd(identity, _usersRepository.GetUserInfo(identity));
                user.UpdateLastActivity();
                return user;
            }
        }

        public UserInfo GetUserInfo(string identity)
        {
            UserInfo user;
            return _usersOnline.TryGetValue(identity, out user) ? user : _usersRepository.GetUserInfo(identity);
        }

        private void RemoveOffline(object state)
        {
            var now = DateTime.Now;
            foreach (var userInfo in _usersOnline)
            {
                if (((now - userInfo.Value.LastActivity).TotalMilliseconds < RefreshInterval))
                    continue;

                UserInfo deleting;
                _usersOnline.TryRemove(userInfo.Key, out deleting);
            }
        }
    }
}