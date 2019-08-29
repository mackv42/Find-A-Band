using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Web;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace FindABand.Controllers
{
    public class Messanger : Hub
    {
        public async Task SendMessage(string user, string message)
        {            
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
