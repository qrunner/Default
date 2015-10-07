using System;
using System.Web.Mvc;
using Crossover.AMS.Dashboard.CommunicationService;
using Crossover.AMS.Dashboard.Models.Communication;

namespace Crossover.AMS.Dashboard.Controllers
{
    public class CommunicationController : Controller
    {
        readonly CommunicationServiceContractClient _client = new CommunicationServiceContractClient();

        //
        // GET: /Communication/Create
        [HttpGet]
        public ActionResult Conference(long accidentId, long confId)
        {
            var confs = _client.GetConferencieList(accidentId);
            var msgs = _client.GetConferenceMessages(confId);
            return View(new ConferenceModel(accidentId, confId, confs, msgs));
        }

        //
        // POST: /Communication/Create

        [HttpPost]
        public ActionResult Conference(FormCollection collection)
        {
            var conferencefId = long.Parse(collection["SelectedConferention"]);
            var accId = long.Parse(collection["AccidentId"]);

            _client.SendConferenceMessage(new ConferenceMessage
            {
                Sended = DateTime.Now,
                SenderSid = AppFactory.MembershipProvider.CurrentUser.Sid,
                ConferenceId = conferencefId,
                Text = collection["MessageText"]
            });
            return RedirectToAction("Conference", new { accidentId = accId, confId = conferencefId  });
        }
    }
}
