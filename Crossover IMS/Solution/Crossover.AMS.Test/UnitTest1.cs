using System;
using System.Diagnostics;
using System.Linq;
using System.Messaging;
using System.Security.Principal;
using Crossover.AMS.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crossover.AMS.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLdapUserRepository()
        {
            IUsersRepository rep = new LdapUsersRepository();
            var user = rep.GetUserInfo(WindowsIdentity.GetCurrent().Name);
            Assert.AreEqual(WindowsIdentity.GetCurrent().Name.Split('\\').Last(), user.Account);
        }

        [TestMethod]
        public void TestLMessageQueue()
        {
            const string queue = @".\PRIVATE$\queue1";
            const string queue2 = @".\PRIVATE$\queue2";
            const string messageText = "hello, I'm a message!";

            if (MessageQueue.Exists(queue))
                MessageQueue.Delete(queue);

            if (!MessageQueue.Exists(queue))
                MessageQueue.Create(queue);


            var mq = new MessageQueue(queue);
            mq.Send(messageText);
            var recieved = mq.Receive(TimeSpan.FromSeconds(2));
            Assert.IsNotNull(recieved);
            Assert.AreEqual(messageText, recieved.Body);

            if (MessageQueue.Exists(queue2))
                MessageQueue.Delete(queue2);

            if (!MessageQueue.Exists(queue2))
                MessageQueue.Create(queue2);
            
            var mq2 = new MessageQueue(queue2);
            var msg2 = new Message(recieved.Body) {CorrelationId = recieved.Id};
            mq2.Send(msg2);
            var recieved2 = mq2.ReceiveByCorrelationId(recieved.Id);
            recieved2.Formatter = new XmlMessageFormatter(new [] { typeof(string) });
            Assert.IsNotNull(recieved2);
            Assert.AreEqual(messageText, recieved2.Body);
        }
    }
}