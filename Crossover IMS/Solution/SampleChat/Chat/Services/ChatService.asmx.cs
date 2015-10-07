using System.ComponentModel;
using System.Messaging;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using Crossover.AMS.Communication.Chat.Entities;

namespace Crossover.AMS.Communication.Chat.Services
{
	/// <summary>
	/// Summary description for ChatService
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[ToolboxItem(false)]
	[ScriptService]
	public class ChatService : WebService
	{
		private static void CheckSiteSecurity()
		{
			if (new SessionWrapper(HttpContext.Current.Session).User == null)
			{
				throw new System.Security.SecurityException("Session lost. Need to be logged in to use the chat.");
			}
		}

		[WebMethod(EnableSession = true)]
		public int EnterRoom(int roomId)
		{
			CheckSiteSecurity();
			var manager = new ChatManager();
			return manager.EnterRoom(roomId);
		}

		[WebMethod(EnableSession = true)]
		public Response CheckUsers()
		{
			CheckSiteSecurity();
			var manager = new ChatManager();
			return manager.CheckUsers();
		}

		[WebMethod(EnableSession = true)]
		public Response CheckMessages(int lastMessage)
		{
			CheckSiteSecurity();
			var manager = new ChatManager();

			return manager.CheckMessages(lastMessage);
		}

		[WebMethod(EnableSession = true)]
		public Response SendMessage(string message, int lastMessageId)
		{
			CheckSiteSecurity();
			var manager = new ChatManager();

			return manager.SendMessage(message, lastMessageId);
		}
	}
}
