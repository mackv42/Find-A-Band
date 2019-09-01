using FindABand.Data;
using FindABand.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;

        public ChatHub(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task SendMessage(int? userId1, int? userId2, int? bandId1, int? bandId2, string message)
        {
            var user = _context.UserAccounts.Where(x => x.ProfileId == userId1).FirstOrDefault();
            var m = new Message();
            m.Text = message;
            m.SenderId = userId1;
            m.SenderBandId = bandId1;
            m.RecipientId = userId2;
            m.RecipientBandId = bandId2;
            await _context.Messages.AddAsync(m);
            await _context.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveMessage", user.FirstName, message);
            //IClientProxy proxy = 
            //await Clients.User("").SendMessage(IClientProxy p);
        }

        public async Task BandSendMessage(string userId1, string userId2, string message)
        {

        }
    }
}