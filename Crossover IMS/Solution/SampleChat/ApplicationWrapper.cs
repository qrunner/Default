using System.Web;
using Crossover.AMS.Communication.Chat.Entities;

namespace Crossover.AMS.Communication
{
    public sealed class ApplicationWrapper
    {
        public HttpApplicationState Application { get; set; }
        
        public ApplicationWrapper(HttpApplicationState application)
        {
            Application = application;
        }
        
        private const string KeyChatRooms = "ChatRooms";

        public RoomCollection ChatRooms
        {
            get
            {
                if (Application[KeyChatRooms] == null)
                {
                    Application[KeyChatRooms] = new RoomCollection();
                }
                return (RoomCollection) Application[KeyChatRooms];
            }
        }
    }
}