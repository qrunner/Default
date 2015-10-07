String.prototype.namespace=function(separator){var ns = this.split(separator||'.'),p=window;for(i=0;i<ns.length;i++){p=p[ns[i]]=p[ns[i]]||{};}};

"Codeproject.Chat".namespace();

Codeproject.Chat.Init = function()
{
	//Global elements
	Codeproject.Chat.UserPanel = document.getElementById("userPanel");
	Codeproject.Chat.MessagePanel = document.getElementById("messagePanel");
	Codeproject.Chat.MessageList = document.getElementById("messageList");
	Codeproject.Chat.MessageTextbox = document.getElementById("txtMessage");
	Codeproject.Chat.MessageButton = document.getElementById("cmdSend");
	
	Codeproject.Chat.MessageTextbox.focus();
	Codeproject.Chat.MessageTextbox.value = "";
	
	//Establish constanst
	Codeproject.Chat.RoomId = 2;
	Codeproject.Chat.CheckUsersRefresh = 10000;
	Codeproject.Chat.CheckMessagesRefresh = 2000;
	Codeproject.Chat.LastMessageId = 0;
	Codeproject.Chat.StopRefresh = true;
	
	if (window.location.href.indexOf("debug") > -1)
	{
		Codeproject.Chat.IsDebug = true;
		Codeproject.Chat.DebugPanel = document.getElementById("chatDebugPanel");
		Codeproject.Chat.DebugPanel.style.display = "";
	}

	Codeproject.Chat.EnterRoom();
}

Codeproject.Chat.EnterRoom = function()
{
    Crossover.AMS.Communication.Chat.Services.ChatService.EnterRoom(Codeproject.Chat.RoomId, Codeproject.Chat.EnterRoomCallback);
}

Codeproject.Chat.EnterRoomCallback = function(lastMessageId)
{
	Codeproject.Chat.LastMessageId = lastMessageId;
	
	Codeproject.Chat.MessagePanel.className = "";
	Codeproject.Chat.CheckUsers();
	
	Codeproject.Chat.CheckMessages();
}

Codeproject.Chat.CheckUsers = function ()
{
	Codeproject.Chat.Notify("Checking Users " + (new Date()));
	//Calls the web service
	Crossover.AMS.Communication.Chat.Services.ChatService.CheckUsers(Codeproject.Chat.CheckUsersCallback);
	
	if (!Codeproject.Chat.StopRefresh)
	{
		setTimeout(Codeproject.Chat.CheckUsers, Codeproject.Chat.CheckUsersRefresh);
	}
}

Codeproject.Chat.CheckUsersCallback = function(response)
{
	if (response.Users.length > 0)
	{
		Codeproject.Chat.ArrangeUsers(response.Users);
	}
}

Codeproject.Chat.CheckMessages = function ()
{
	Codeproject.Chat.Notify("Checking Messages from id: " + Codeproject.Chat.LastMessageId + " at " + (new Date()));
	//Calls the web service
	Crossover.AMS.Communication.Chat.Services.ChatService.CheckMessages(Codeproject.Chat.LastMessageId, Codeproject.Chat.CheckMessagesCallback);
	
	if (!Codeproject.Chat.StopRefresh)
	{
		setTimeout(Codeproject.Chat.CheckMessages, Codeproject.Chat.CheckMessagesRefresh);
	}
}

Codeproject.Chat.CheckMessagesCallback = function(response)
{
	if (response.Messages.length > 0)
	{
		if (Codeproject.Chat.LastMessageId < response.LastMessageId)
		{
			Codeproject.Chat.LastMessageId = response.LastMessageId
			Codeproject.Chat.ArrangeMessages(response.Messages);
		}
	}
	if (response.Users.length > 0)
	{
		Codeproject.Chat.ArrangeUsers(response.Users);
	}
	Codeproject.Chat.Notify("Check Messages Calledback with id: " + Codeproject.Chat.LastMessageId);
}

//Arrange the user collection in the user's panel.
Codeproject.Chat.ArrangeUsers = function(users)
{
		var list = document.createElement("UL");
		for (var i=0;i<users.length;i++)
		{
			var element = document.createElement("LI");
			var user = users[i];
			element.innerHTML = user.UserName;
			list.appendChild(element);
		}
		Codeproject.Chat.UserPanel.innerHTML = "";
		Codeproject.Chat.UserPanel.appendChild(list);

}

Codeproject.Chat.ArrangeMessages = function (messages)
{
		for (var i=0;i<messages.length;i++)
		{
			var element = document.createElement("LI");
			var message = messages[i];
			//(new Date()).format("HH:MM") + "hs"
			element.innerHTML = "<span class=\"userName\">" + message.UserName + "</span>";
			element.innerHTML += ": " + message.MessageBody;
			
			Codeproject.Chat.MessageList.appendChild(element);
			
			Codeproject.Chat.MessagePanel.scrollTop = Codeproject.Chat.MessagePanel.scrollHeight;
		}
}

Codeproject.Chat.SendMessage = function ()
{
	var message = Codeproject.Chat.MessageTextbox.value;
	if (message.trim() != "")
	{
		Crossover.AMS.Communication.Chat.Services.ChatService.SendMessage(message, Codeproject.Chat.LastMessageId, Codeproject.Chat.CheckMessagesCallback);
		Codeproject.Chat.MessageTextbox.focus();
		Codeproject.Chat.MessageTextbox.value = "";
	}
}

Codeproject.Chat.CheckSend = function (e)
{
	if(window.event)
	{
		keynum = e.keyCode;
	}
	else if(e.which)
	{
		keynum = e.which;
	}
	if (keynum == 13)
	{
		Codeproject.Chat.SendMessage();
	}
}

Codeproject.Chat.Notify = function (message)
{
	if (Codeproject.Chat.IsDebug)
	{
		var elem = document.createElement("SPAN");
		elem.innerHTML = "<br /> <a onclick='Codeproject.Chat.StopRefresh = true;return false;' href='#'>stop</a> " + message;
		Codeproject.Chat.DebugPanel.insertBefore(elem, Codeproject.Chat.DebugPanel.childNodes[0]);
	}
}