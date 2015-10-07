using System;
using Crossover.AMS.Communication.Chat.Entities;

namespace Crossover.AMS.Communication
{
	public partial class ChatTest : System.Web.UI.Page
	{
		protected override void OnLoad(EventArgs e)
		{
			var session = new SessionWrapper(Session);
			if (session.User == null)
			{
				session.User = new SiteUser(Convert.ToInt32(Request["u"]), Request["n"]);
			}

			base.OnLoad(e);
		}
	}
}
