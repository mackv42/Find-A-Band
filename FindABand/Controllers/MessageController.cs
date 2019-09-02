using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FindABand.Data;
using FindABand.Models;
using FindABand.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindABand.Controllers
{
    public class MessageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MessageController(ApplicationDbContext context)
        {
            _context = context;
        }

            // GET: Message
        

         //band or user your messaging and band your sending messages as
        public ActionResult Messages(int? usermId, int? bandmId, int? bandsId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();

            var allMessages = _context.Messages.Where(x => x.SenderId == userAccount.ProfileId);
            if(bandsId != null)
            {
                allMessages = _context.Messages.Where(x => x.RecipientBandId == bandsId || x.SenderBandId == bandsId);
            }

            var Messages = new List<Message>();
            if(usermId != null)
            {
                Messages = allMessages.Where(x => x.SenderId == usermId || x.RecipientId == usermId).ToList();
            } else if(bandmId != null)
            {
                Messages = allMessages.Where(x => x.SenderBandId == bandmId || x.RecipientBandId == bandmId).ToList();
            }
            
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();

            //var bandAccount = new UserAccount();
            //if (bandId == null)
            //{
            //    //bandAccount = _context.Bands.Where(x => x.BandId == bandId).FirstOrDefault();
            //}
            //else
            //{
            //    bandAccount = _context.UserAccounts.Where(x => x.ProfileId == accountId).FirstOrDefault();
            //}

            //var messages = _context.Messages.Where(x => x.SenderId == userAccount.ProfileId || x.RecipientId == userAccount.ProfileId);
            //messages = messages.Where(x => x.SenderId == userAccount.ProfileId && x.RecipientId == userAccount.ProfileId);
            //MessageViewModel m = new MessageViewModel();
            //m.Messages = messages.ToList();
            //m.MyId = userAccount.ProfileId;
            //m.UserId = bandAccount.ProfileId;
            MessageViewModel m = new MessageViewModel();
            m.Messages = Messages;
            m.MyBandId = bandsId;
            m.UserId = usermId;
            m.BandId = bandmId;
            return View(m);
        }

        [HttpPost]
        public ActionResult Messages(int? usermId, int? bandmId, int? bandsId, string text)
        {
            Message newMessage = new Message();

            newMessage.SenderBandId = bandsId;

            if(bandsId == null)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                newMessage.SenderId = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault().ProfileId;
            }
            newMessage.RecipientId = usermId;
            newMessage.RecipientBandId = bandmId;
            newMessage.Text = text;

            _context.Messages.Add(newMessage);
            _context.SaveChanges();

            //return View($"../Messages/?usermId={usermId}&bandmId={bandmId}&bandsId={bandsId}");
            return RedirectToAction("Messages", new { usermId = usermId, bandmId = bandmId, bandsId = bandsId});
        }

        public ActionResult BandMessages(int? bandid, int? accountId) 
        {
            return View();
        }

        /*public ActionResult BandMessages(int userId, int bandId)
        {

        }*/
      
    }
}