using System.Collections.Generic;
using System.Linq;
using Crossover.AMS.Communication.Model;
using Crossover.AMS.Contracts.Communication;

namespace Crossover.AMS.Communication
{
    public class CommunicationService : ICommunicationService
    {
        public void SendConferenceMessage(IConferenceMessage message)
        {
            using (var ctx = new DataContext())
            {
                ctx.Conferences.Single(x=>x.Id == message.ConferenceId).Messages.Add(new ConferenceMessage(message));
                ctx.SaveChanges();
            }
        }

        public void SendPrivateMessage(IPrivateMessage message)
        {
            using (var ctx = new DataContext())
            {
                ctx.PrivateMessages.Add(new PrivateMessage(message));
                ctx.SaveChanges();
            }
        }

        public IEnumerable<IPrivateMessage> GetPrivateMessages(string senderSid, string recipientSid)
        {
            using (var ctx = new DataContext())
            {
                return ctx.PrivateMessages.Where(x => (x.RecipientSid == recipientSid & x.SenderSid == senderSid) && (x.RecipientSid == senderSid & x.SenderSid == recipientSid)).ToArray();
            }
        }

        public IEnumerable<string> GetNewPrivateSenders(string recipientSid)
        {
            using (var ctx = new DataContext())
            {
                return ctx.PrivateMessages.Where(x => x.RecipientSid == recipientSid && !x.Readed).Select(x => x.SenderSid).ToArray();
            }
        }

        public void MarkAsReaded(IPrivateMessage message)
        {
            using (var ctx = new DataContext())
            {
                ctx.PrivateMessages.Single(x => x.Id == message.Id).Readed = true;
                ctx.SaveChanges();
            }
        }

        public IEnumerable<IConferenceMessage> GetConferenceMessages(long conferenceId)
        {
            using (var ctx = new DataContext())
            {
                return ctx.Conferences.Single(x => x.Id == conferenceId).Messages.OrderBy(x => x.Id).ToArray();
            }
        }

        public IConference CreateConference(long accidentId, string title)
        {
            using (var ctx = new DataContext())
            {
                var conference = new Conference
                {
                    State = ConferenceState.Active,
                    Title = title,
                    AccidentId = accidentId
                };
                ctx.Conferences.Add(conference);
                ctx.SaveChanges();
                return conference;
            }
        }

        public void UpdateConference(IConference conference)
        {
            using (var ctx = new DataContext())
            {
                var dbConference = ctx.Conferences.Single(x => x.Id == conference.Id);
                dbConference.State = conference.State;
                dbConference.Title = conference.Title;
                dbConference.AccidentId = conference.AccidentId;
                ctx.SaveChanges();
            }
        }

        public void DeleteConference(long conferenceId)
        {
            using (var ctx = new DataContext())
            {
                ctx.Conferences.Remove(ctx.Conferences.Single(x => x.Id == conferenceId));
                ctx.SaveChanges();
            }
        }

        public IEnumerable<IConference> GetConferencieList(long accidentId)
        {
            using (var ctx = new DataContext())
            {
                return ctx.Conferences.Where(x => x.AccidentId == accidentId).ToArray();
            }
        }
    }
}