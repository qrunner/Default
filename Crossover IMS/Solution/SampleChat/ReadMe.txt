Hi,
I tryed to organize it as easy for you as possible.
	- The control on \Chat\Controls\Chat.ascx is responsable of the client code for the chat
	- The Webservice on \Chat\Services\ChatService.asmx is the one handling all the ajax request.
	- The ChatManager is the real-deal, there is most of the logic needed.
	
There some issues that are out of scope of the article, like Application
and Session Wrappers (that are just helpers to access the session or the 
application, check out the class summary) or how to access the data (in this
case I'm using basic SqlCommands/SqlDataAdapters), but do not take this into
consideration.

Hope you enjoy it!
Jorgebg
