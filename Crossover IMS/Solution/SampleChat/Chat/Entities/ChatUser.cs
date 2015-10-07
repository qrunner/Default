using System;
using System.Xml.Serialization;

namespace Crossover.AMS.Communication.Chat.Entities
{
    [Serializable]
    public class ChatUser
    {
        public ChatUser()
        {
        }

        public ChatUser(int userId, string userName)
        {
            UserId = userId;
            UserName = userName;
            LastActivity = DateTime.Now;
        }
        
        [XmlIgnore]
        public DateTime LastActivity { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }
    }
}