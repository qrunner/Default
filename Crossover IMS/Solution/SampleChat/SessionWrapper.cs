using System;
using System.Web;
using System.Web.SessionState;
using Crossover.AMS.Communication.Chat.Entities;

namespace Crossover.AMS.Communication
{
    /// <summary>
    /// Just a wrapper in order to hardcode all the session keys inside this class 
    /// and not all over the application
    /// </summary>
    public class SessionWrapper
    {
        protected HttpSessionState Session { get; set; }

        public SessionWrapper(HttpSessionState session)
        {
            Session = session;
        }

        private const string KeyUser = "User";

        public SiteUser User
        {
            get
            {
                return new SiteUser(0, HttpContext.Current.User.Identity.Name);
                return (SiteUser)Session[KeyUser];
            }
            set { Session[KeyUser] = value; }
        }

        private const string KeyRoomUsersDate = "GotRoomUsers";

        /// <summary>
        /// The last time the user 
        /// </summary>
        public DateTime RoomUsersDate
        {
            get
            {
                if (Session[KeyRoomUsersDate] == null)
                {
                    Session[KeyRoomUsersDate] = DateTime.MinValue;
                }
                return (DateTime)Session[KeyRoomUsersDate];
            }
            set { Session[KeyRoomUsersDate] = value; }
        }

        private const string KeyRoomId = "RoomId";

        /// <summary>
        /// The current room id
        /// </summary>
        public int RoomId
        {
            get { return Session[KeyRoomId] == null ? 0 : (int)Session[KeyRoomId]; }
            set { Session[KeyRoomId] = value; }
        }

        private const string KeyLastMessageId = "LastMessageId:";

        /// <summary>
        /// The last message id of the room, dependant of Room Id.
        /// </summary>
        public int? LastMessageId
        {
            get { return (int?)Session[KeyLastMessageId + RoomId]; }
            set { Session[KeyLastMessageId + RoomId] = value; }
        }
    }
}