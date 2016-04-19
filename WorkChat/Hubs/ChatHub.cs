using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WorkChat.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string name, string message, int connectionId)
        {        
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message, connectionId);
        }
        
    }
}