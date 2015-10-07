using System;
using System.Collections.Generic;

namespace Crossover.AMS.Communication.Chat.Entities
{
    [Serializable]
    public class Response
    {
        public List<ChatUser> Users { get; set; }

        public List<Message> Messages { get; set; }

        public int LastMessageId { get; set; }

        public Response()
        {
            Users = new List<ChatUser>();
            Messages = new List<Message>();
        }

        public Response(List<ChatUser> users, List<Message> messages)
        {
            Users = users;
            Messages = messages;
        }

        public Response(List<ChatUser> users)
        {
            Users = users;
            Messages = new List<Message>();
        }

        public Response(List<Message> messages)
        {
            Users = new List<ChatUser>();
            Messages = messages;
        }
    }
}