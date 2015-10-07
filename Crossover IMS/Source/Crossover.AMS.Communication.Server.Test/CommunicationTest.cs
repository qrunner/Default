using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using Crossover.AMS.Communication.Server.Test.ServiceReference1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crossover.AMS.Communication.Server.Test
{
    [TestClass]
    public class CommunicationTest
    {
        private const long AccidentId = 1;

        [TestMethod]
        public void TestCreateConference()
        {
            var client = new CommunicationServiceContractClient();
            var conf = client.CreateConference(AccidentId, "Virtual Room 2");
            var selectedConf = client.GetConferencieList(AccidentId).SingleOrDefault(x => x.Id == conf.Id);
            Assert.IsNotNull(selectedConf);
            Assert.AreEqual(conf.State, selectedConf.State);
            Assert.AreEqual(conf.Title, selectedConf.Title);
        }

        [TestMethod]
        public void TestSendConferenceMessage()
        {
            var client = new CommunicationServiceContractClient();
            var conf = client.GetConferencieList(AccidentId).First();

            var newMessage = new ConferenceMessage
            {
                ConferenceId = conf.Id,
                SenderSid = WindowsIdentity.GetCurrent().Name,
                Text = "Test Message",
                Sended = DateTime.Now
            };

            client.SendConferenceMessage(newMessage);

            var message = client.GetConferenceMessages(conf.Id).LastOrDefault();

            Assert.IsNotNull(message);
            Assert.AreEqual(newMessage.Sended, message.Sended);
        }
    }
}