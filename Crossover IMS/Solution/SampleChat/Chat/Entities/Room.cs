using System;
using System.Collections.Generic;

namespace Crossover.AMS.Communication.Chat.Entities
{
    public class Room
    {
        private readonly Dictionary<int, ChatUser> _users;

        public Room()
        {
            _users = new Dictionary<int, ChatUser>();

            LastUserChange = DateTime.Now;
        }

        /// <summary>
        /// Active users in the chat room
        /// </summary>
        public Dictionary<int, ChatUser> Users
        {
            get { return _users; }
        }

        /// <summary>
        /// The last time that the system validated active user.
        /// To avoid going all through the collection and validating if the users a valid more than once.
        /// </summary>
        public DateTime LastUserChange { get; set; }

        /// <summary>
        /// Checks if any of user is inactive, if true, then is removed from the chat list
        /// </summary>
        /// <param name="maxInterval"></param>
        public void ValidateUsers(TimeSpan maxInterval)
        {
            var toDelete = new List<int>();
            foreach (var keyValue in Users)
            {
                if (DateTime.Now.Subtract(keyValue.Value.LastActivity) > maxInterval)
                    toDelete.Add(keyValue.Key);
            }

            foreach (var userId in toDelete)
            {
                Users.Remove(userId);
            }
            LastUserChange = DateTime.Now;
        }

        /// <summary>
        /// Add a new user to the room if needed.
        /// </summary>
        public void EnterRoom(int userId, string userName)
        {
            if (!Users.ContainsKey(userId))
                Users.Add(userId, new ChatUser(userId, userName));
            else
                Users[userId].LastActivity = DateTime.Now;

            LastUserChange = DateTime.Now;
        }

        /// <summary>
        /// Removes the user from the room
        /// </summary>
        /// <param name="userId"></param>
        public void LeaveRoom(int userId)
        {
            Users.Remove(userId);

            LastUserChange = DateTime.Now;
        }
    }
}