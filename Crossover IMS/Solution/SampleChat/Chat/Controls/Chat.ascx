<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="Chat.ascx.cs" Inherits="Crossover.AMS.Communication.Chat.Controls.Chat" %>
<asp:ScriptManager id="sm" runat="server" >
	<Services>
		 <asp:ServiceReference Path="~/Chat/Services/ChatService.asmx"/>
	</Services>
</asp:ScriptManager> 


<div id="chatPanel">
	<div id="chatBody">
		<div id="messagePanel" class="Loading">
			<ul id="messageList"></ul>
		</div>
		<div id="userPanel">
		
		</div>
	</div>
	<div id="chatFooter">
		<input type="text" id="txtMessage" onkeypress="return Codeproject.Chat.CheckSend(event);" />
		<input type="button" id="cmdSend" value="Send" style="display:none;" onclick="Codeproject.Chat.SendMessage();return false;" />
	</div>
</div>
<div id="chatDebugPanel" style="display: none;">
	<span><!-- required --></span>
</div>

<script type="text/javascript">
	window.onload = function()
	{
		Codeproject.Chat.Init();
	}
</script>