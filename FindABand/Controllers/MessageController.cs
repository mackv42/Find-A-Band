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

         //band or user your messaging and band your sending messages as
        public ActionResult Messages(int? usermId, int? bandmId, int? bandsId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();

            var allMessages = _context.Messages.Where(x => x.SenderId == userAccount.ProfileId || x.RecipientId == userAccount.ProfileId);
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
            
            MessageViewModel m = new MessageViewModel();
            m.Messages = Messages;
            m.MyBandId = bandsId;
            m.MyProfileId = userAccount.ProfileId;
            m.UserId = usermId;
            m.BandId = bandmId;

            if(bandmId == null)
            {
                m.Name = _context.UserAccounts.Where(x => x.ProfileId == usermId).FirstOrDefault().FirstName;
            }
            else
            {
                m.Name = _context.Bands.Where(x => x.BandId == bandmId).FirstOrDefault().Name;
            }
            return View(m);
        }

        [HttpPost]
        public ActionResult Messages(int? usermId, int? bandmId, int? bandsId, string text)
        {
            Message newMessage = new Message();

            if(bandsId == null)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                newMessage.SenderId = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault().ProfileId;
            }

            newMessage.SenderBandId = bandsId;
            newMessage.RecipientId = usermId;
            newMessage.RecipientBandId = bandmId;
            newMessage.Text = text;

            _context.Messages.Add(newMessage);
            _context.SaveChanges();

            //return View($"../Messages/?usermId={usermId}&bandmId={bandmId}&bandsId={bandsId}");
            return RedirectToAction("Messages", new { usermId = usermId, bandmId = bandmId, bandsId = bandsId});
        }
      
    }
}