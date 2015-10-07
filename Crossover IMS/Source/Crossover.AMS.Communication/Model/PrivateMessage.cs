using System.Runtime.Serialization;
using Crossover.AMS.Contracts.Communication;
using System;

namespace Crossover.AMS.Communication.Model
{
    [DataContract]
    public class PrivateMessage : Message, IPrivateMessage
    {
        public PrivateMessage()
        {
        }

        public PrivateMessage(IPrivateMessage source)
            : base(source)
        {
            Readed = source.Readed;
            RecipientSid = source.RecipientSid;
        }

        [DataMember]
        public string RecipientSid { get; set; }

        [DataMember]
        public bool Readed { get; set; }
    }
}