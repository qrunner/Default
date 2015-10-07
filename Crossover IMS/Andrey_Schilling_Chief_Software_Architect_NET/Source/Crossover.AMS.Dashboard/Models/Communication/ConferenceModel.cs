using System.Collections.Generic;
using Crossover.AMS.Dashboard.CommunicationService;

namespace Crossover.AMS.Dashboard.Models.Communication
{
    public class ConferenceModel
    {
        public ConferenceModel(long accidentId, long selectedConferention, IEnumerable<Conference> conferences, IEnumerable<ConferenceMessage> messages)
        {
            AccidentId = accidentId;
            SelectedConferention = selectedConferention;
            Conferences = conferences;
            Messages = messages;
        }

        public long AccidentId { get; private set; }

        public long SelectedConferention { get; private set; }

        public IEnumerable<Conference> Conferences { get; protected set; }

        public IEnumerable<ConferenceMessage> Messages { get; protected set; }

        public string MessageText { get; set; }
    }
}