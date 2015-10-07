using System;

namespace Crossover.AMS.Communication.Chat.Entities
{
    [Serializable]
    public class Message
    {
        public Message()
        {
        }

        public Message(int id, string messageBody, string userName, DateTime date)
        {
            Id = id;
            MessageBody = messageBody;
            UserName = userName;
            Date = date;
        }

        public string MessageBody { get; set; }

        public string UserName { get; set; }

        public DateTime Date { get; set; }

        public int Id { get; set; }
    }
}