using System;

namespace Crossover.AMS.Models
{
    public class UserInfo
    {
        public UserInfo(byte[] guid, string account, string fullName, string email)
        {
            Id = new Guid(guid);
            Account = account;
            FullName = fullName;
            Email = email;
        }

        /// <summary>
        /// User guid
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Account name
        /// </summary>
        public string Account { get; private set; }

        /// <summary>
        /// User full name
        /// </summary>
        public string FullName { get; private set; }

        /// <summary>
        /// User e-mail
        /// </summary>
        public string Email { get; private set; }

        public DateTime LastActivity { get; set; }

        public void UpdateLastActivity()
        {
            LastActivity = DateTime.Now;
        }
    }
}