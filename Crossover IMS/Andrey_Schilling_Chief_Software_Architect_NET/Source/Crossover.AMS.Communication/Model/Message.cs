using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Crossover.AMS.Contracts.Communication;

namespace Crossover.AMS.Communication.Model
{
    [DataContract]
    public class Message : IMessage
    {
        public Message()
        {
        }

        public Message(IMessage source)
        {
            Id = source.Id;
            Text = source.Text;
            Sended = source.Sended;
            Attachments = source.Attachments;
            SenderSid = source.SenderSid;
        }

        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public string[] Attachments { get; set; }

        [DataMember]
        [Column(TypeName = "datetime2")]
        public DateTime Sended { get; set; }

        [DataMember]
        public string SenderSid { get; set; }
    }
}