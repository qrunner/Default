<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChatTest.aspx.cs" Inherits="Crossover.AMS.Communication.ChatTest" %>
<%@ Register TagPrefix="UC" Src="~/Chat/Controls/Chat.ascx" TagName="Chat" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
    
<head id="Head1" runat="server">
    
    <title>Untitled Page</title>
	<link href="/styles/chat.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/scripts/chat.js"></script>
</head>
<body>
    <form runat="server" onsubmit="">
	<asp:ScriptManager id="sm" runat="server" >
	<Services>
		 <asp:ServiceReference Path="~/Chat/Services/ChatService.asmx"/>
	</Services>
</asp:ScriptManager> 
    
    <h1>Sample chat client</h1>
        
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
		<input type="button" id="cmdSend" value="Send" style="display:none;" onclick="Codeproject.Chat.SendMessage(); return false;" />
	</div>
</div>
<div id="chatDebugPanel" style="display: none;">
	<span><!-- required --></span>
</div>

<script type="text/javascript">
    window.onload = function () {
        Codeproject.Chat.Init();
    }

    window.onbeforeunload = function () {
        confirm("close ?");
        return false; /* which will not allow to close the window */
    }
</script>
    </form>
</body>
</html>
