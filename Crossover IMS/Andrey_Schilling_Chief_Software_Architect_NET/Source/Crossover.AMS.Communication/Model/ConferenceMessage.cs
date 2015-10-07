using System.Runtime.Serialization;
using Crossover.AMS.Contracts.Communication;

namespace Crossover.AMS.Communication.Model
{
    [DataContract]
    public class ConferenceMessage : Message, IConferenceMessage
    {
        public ConferenceMessage()
        {
        }

        public ConferenceMessage(IConferenceMessage source) : base(source)
        {
            ConferenceId = source.ConferenceId;
        }

        [DataMember]
        public long ConferenceId { get; set; }

        public virtual Conference Conference { get; set; }
    }
}