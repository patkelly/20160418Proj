using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WorkChat.Hubs
{
    public class ChatDashboardHub : Hub
    {
        public void SendMessage(string name, string message)
        {
            
            Clients.All.broadcastMessage(name, message);
        }

        public void SendLiveQueue(IList<string> liveQueue)
        {
            Clients.All.broadcastLiveQueue(liveQueue);
        }
    }
}