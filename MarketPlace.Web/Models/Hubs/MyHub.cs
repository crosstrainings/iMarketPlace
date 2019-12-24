using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;

namespace iMarketPlace.Web.Models.Hubs
{
    [HubName("myHub")]
    public class MyHub : Hub
    {
        public void SayWelcome()
        {
            Clients.All.SayWelcome(DateTime.Now);
        }

    }
}