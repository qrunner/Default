using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using Crossover.AMS.Communication.Chat.Entities;

namespace Crossover.AMS.Communication.Chat.Data
{
	public static class ChatDataAccess
	{
	    public static void MessageInsert(int roomId, string message, DateTime date, int userId, bool isSystem)
	    {
	        var command = new SqlCommand
	        {
	            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString),
	            CommandType = CommandType.StoredProcedure,
	            CommandText = "SPChatMessagesInsert"
	        };

	        command.Parameters.Add(new SqlParameter("@RoomId", roomId));
	        command.Parameters.Add(new SqlParameter("@MessageBody", message));
	        command.Parameters.Add(new SqlParameter("@MessageDate", date));
	        command.Parameters.Add(new SqlParameter("@UserId", userId));
	        command.Parameters.Add(new SqlParameter("@IsSystem", isSystem));

	        try
	        {
	            command.Connection.Open();
	            command.ExecuteNonQuery();
	        }
	        finally
	        {
	            command.Connection.Close();
	        }
	    }

	    public static List<Message> GetRoomMessages(int lastMessageId, int roomId)
		{
			var messages = new List<Message>();
			var dt = new DataTable();

			var command = new SqlCommand
			{
			    Connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString), 
                CommandType = CommandType.StoredProcedure, 
                CommandText = "SPChatMessagesGet"
			};

		    command.Parameters.Add(new SqlParameter("@LastMessageId", lastMessageId));
			command.Parameters.Add(new SqlParameter("@RoomId", roomId));

			var da = new SqlDataAdapter(command);
			da.Fill(dt);

			foreach (DataRow dr in dt.Rows)
			{
				messages.Add(new Message(Convert.ToInt32(dr["MessageId"]), dr["MessageBody"].ToString(), dr["UserName"].ToString(), Convert.ToDateTime(dr["MessageDate"])));
			}

			return messages;
		}

		public static int GetLastMessage()
		{
			var dt = new DataTable();

			var command = new SqlCommand
			{
			    Connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString), 
                CommandType = CommandType.StoredProcedure,
                CommandText = "SPChatMessagesGetLastMessage"
			};

		    var da = new SqlDataAdapter(command);
			da.Fill(dt);
			return Convert.ToInt32(dt.Rows[0][0]);
		}
	}
}
