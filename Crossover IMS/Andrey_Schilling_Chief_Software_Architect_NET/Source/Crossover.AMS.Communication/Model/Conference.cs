using System.Collections.Generic;
using System.Runtime.Serialization;
using Crossover.AMS.Contracts.Communication;

namespace Crossover.AMS.Communication.Model
{
    [DataContract]
    public class Conference : IConference
    {
        public Conference()
        {
        }

        public Conference(IConference source)
        {
            Id = source.Id;
            Title = source.Title;
            State = source.State;
            AccidentId = source.AccidentId;
        }

        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public long AccidentId { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public ConferenceState State { get; set; }

        public virtual ICollection<ConferenceMessage> Messages { get; set; }
    }
}