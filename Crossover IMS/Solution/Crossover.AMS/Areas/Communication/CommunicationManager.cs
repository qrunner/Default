using System;
using System.Linq;
using System.Web;
using Crossover.AMS.Communication.Models;
using Crossover.AMS.Models;

namespace Crossover.AMS.Communication
{
    public static class CommunicationManager
    {
        public static void JoinRoom(int roomId)
        {
            using (var ctx = new Context())
            {
                var userIdentity = HttpContext.Current.User.Identity.Name;
                var room = ctx.Rooms.Single(x => x.Id == roomId);

                if (room.Users.All(x => x.Account != userIdentity))
                    room.Users.Add(ApplicationRoots.UsersManager.CurrentUser);

                ctx.SaveChanges();
            }
        }

        public static void LeaveRoom(int roomId)
        {
            using (var ctx = new Context())
            {
                var userIdentity = HttpContext.Current.User.Identity.Name;
                var room = ctx.Rooms.Single(x => x.Id == roomId);

                if (room.Users.Any(x => x.Account == userIdentity))
                    room.Users.Remove(ApplicationRoots.UsersManager.CurrentUser);

                ctx.SaveChanges();
            }
        }

        public static void SendMessage(int roomId, string text, string[] attachemnts)
        {
            using (var ctx = new Context())
            {
                var room = ctx.Rooms.Single(x => x.Id == roomId);
                room.Messages.Add(new Message
                {
                    Timestamp = DateTime.Now,
                    Room = room,
                    Text = text,
                    Attachments = attachemnts,
                    UserAccount = HttpContext.Current.User.Identity.Name
                });
                ctx.SaveChanges();
            }
        }

        public static int GetConversationRoom(string userAccount)
        {
            var currentUser = HttpContext.Current.User.Identity.Name;
            using (var ctx = new Context())
            {
                var room = ctx.Rooms.SingleOrDefault(x => x.Type == RoomType.Conversation && (
                    (x.User1 == currentUser & x.User2 == userAccount) ||
                    (x.User2 == currentUser & x.User1 == userAccount)));

                if (room == null)
                {
                    room = new Room {Permanent = false, Type = RoomType.Conversation, User1 = currentUser, User2 = userAccount};
                    ctx.Rooms.Add(room);
                    ctx.SaveChanges();
                }

                return room.Id;
            }
        }
    }
}