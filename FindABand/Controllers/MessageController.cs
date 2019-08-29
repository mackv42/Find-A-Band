using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FindABand.Data;
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
      
        public ActionResult Messages(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();
            var bandAccount = _context.Bands.Where(x => x.BandId == id).FirstOrDefault();
            var messages = _context.Messages.Where(x => x.SenderId == userAccount.ProfileId || x.RecipientId == userAccount.ProfileId);
            messages = messages.Where(x => x.SenderId == userAccount.ProfileId && x.RecipientId == id);
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