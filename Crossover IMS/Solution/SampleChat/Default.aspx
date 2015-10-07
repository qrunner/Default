<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Crossover.AMS.Communication.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
	<link href="/styles/chat.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function openChat() {
            window.open("ChatTest.aspx", "_blank", "toolbar=yes, scrollbars=yes, resizable=yes, top=500, left=500, width=400, height=400");
        }
</script>	
</head>
<body>
	<h1>Sample chat client</h1>
    <button onclick="openChat()">Enter Chat</button>
</body>
</html>