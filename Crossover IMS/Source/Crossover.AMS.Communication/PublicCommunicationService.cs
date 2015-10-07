using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using Crossover.AMS.Communication.Model;

namespace Crossover.AMS.Communication
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PublicCommunicationService : ICommunicationServiceContract
    {
        private readonly CommunicationService _service = new CommunicationService();

        public void SendConferenceMessage(ConferenceMessage message)
        {
            _service.SendConferenceMessage(message);
            Console.WriteLine("ConferenceMessage: {0}",message.Text);
        }

        public void SendPrivateMessage(PrivateMessage message)
        {
            _service.SendPrivateMessage(message);
        }

        public IEnumerable<PrivateMessage> GetPrivateMessages(string senderSid, string recipientSid)
        {
            return _service.GetPrivateMessages(senderSid, recipientSid).Select(x => new PrivateMessage(x));
        }

        public IEnumerable<string> GetNewPrivateSenders(string recipientSid)
        {
            return _service.GetNewPrivateSenders(recipientSid);
        }

        public void MarkAsReaded(PrivateMessage message)
        {
            _service.MarkAsReaded(message);
        }

        public IEnumerable<ConferenceMessage> GetConferenceMessages(long conferenceId)
        {
            return _service.GetConferenceMessages(conferenceId).Select(x => new ConferenceMessage(x));
        }

        public Conference CreateConference(long accidentId, string title)
        {
            return new Conference(_service.CreateConference(accidentId, title));
        }

        public void UpdateConference(Conference conference)
        {
            _service.UpdateConference(conference);
        }

        public void DeleteConference(long conferenceId)
        {
            _service.DeleteConference(conferenceId);
        }

        public IEnumerable<Conference> GetConferencieList(long accidentId)
        {
            return _service.GetConferencieList(accidentId).Select(x => new Conference(x));
        }
    }
}