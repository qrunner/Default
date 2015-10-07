using System;
using Crossover.AMS.Models;

namespace Crossover.AMS.Communication.Models
{
    /// <summary>
    /// Chat text message
    /// </summary>
    public class Message : Entity
    {
        private UserInfo _user;

        /// <summary>
        /// Room of message
        /// </summary>
        public virtual Room Room { get; set; }

        /// <summary>
        /// Message contents
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Links to attachments
        /// </summary>
        public string[] Attachments { get; set; }

        /// <summary>
        /// Message date and time
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Author of message
        /// </summary>
        public UserInfo User
        {
            get { return _user ?? (_user = ApplicationRoots.UsersManager.GetUserInfo(UserAccount)); }
        }

        /// <summary>
        /// User account name
        /// </summary>
        public string UserAccount { get; set; }
    }
}