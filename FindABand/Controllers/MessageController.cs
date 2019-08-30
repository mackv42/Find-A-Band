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
      
        public ActionResult Messages(int? accountId, int? bandId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();

            var bandAccount = new UserAccount();
            if (bandId == null)
            {
                //bandAccount = _context.Bands.Where(x => x.BandId == bandId).FirstOrDefault();
            }
            else
            {
                bandAccount = _context.UserAccounts.Where(x => x.ProfileId == accountId).FirstOrDefault();
            }
            
            var messages = _context.Messages.Where(x => x.SenderId == userAccount.UserId || x.RecipientId == userAccount.UserId);
            messages = messages.Where(x => x.SenderId == userAccount.UserId && x.RecipientId == userId);
            MessageViewModel m = new MessageViewModel();
            m.Messages = messages.ToList();
            m.MyId = userId;
            m.UserId = bandAccount.UserId;

            return View(m);
        }

        public ActionResult BandMessages(int id)
        {
            return View();
        }

        /*public ActionResult BandMessages(int userId, int bandId)
        {

        }*/
      
    }
}