using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using Crossover.AMS.Communication.Model;

namespace Crossover.AMS.Communication
{
    [ServiceContract(Namespace = "Crossover.AMS.Communication")]
    internal interface ICommunicationServiceContract
    {
        [OperationContract]
        void SendConferenceMessage(ConferenceMessage message);

        [OperationContract]
        void SendPrivateMessage(PrivateMessage message);

        [OperationContract]
        [WebGet]
        IEnumerable<PrivateMessage> GetPrivateMessages(string senderSid, string recipientSid);

        [OperationContract]
        [WebGet]
        IEnumerable<string> GetNewPrivateSenders(string recipientSid);

        [OperationContract]
        void MarkAsReaded(PrivateMessage message);

        [OperationContract]
        [WebGet]
        IEnumerable<ConferenceMessage> GetConferenceMessages(long conferenceId);

        [OperationContract]
        [WebGet]
        Conference CreateConference(long accidentId, string title);

        [OperationContract]
        void UpdateConference(Conference conference);

        [OperationContract]
        void DeleteConference(long conferenceId);

        [OperationContract]
        [WebGet]
        IEnumerable<Conference> GetConferencieList(long accidentId);
    }
}