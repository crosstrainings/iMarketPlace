using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMarketPlace.Web.Models.Hubs
{
    [HubName("adminHub")]
    public class AdminHub:Hub
    {
        public void UserLogedIn(string userName)
        {
            Clients.All.AddActiveUser(userName);
        }
    }
}
