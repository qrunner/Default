using System.Collections.Generic;

namespace Crossover.AMS.Contracts.Communication
{
    public interface ICommunicationService
    {
        void SendConferenceMessage(IConferenceMessage message);

        void SendPrivateMessage(IPrivateMessage message);

        IEnumerable<IPrivateMessage> GetPrivateMessages(string senderSid, string recipientSid);

        IEnumerable<string> GetNewPrivateSenders(string recipientSid);

        void MarkAsReaded(IPrivateMessage message);

        IEnumerable<IConferenceMessage> GetConferenceMessages(long conferenceId);

        IConference CreateConference(long accidentId, string title);

        void UpdateConference(IConference conference);

        void DeleteConference(long conferenceId);

        IEnumerable<IConference> GetConferencieList(long accidentId);
    }
}