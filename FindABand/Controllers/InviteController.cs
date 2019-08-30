using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FindABand.Data;
using FindABand.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FindABand.Controllers
{
    public class InviteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InviteController(ApplicationDbContext context)
        {
            _context = context;
        }

            // GET: Invite
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserCreate(int? bandId, int? userId)
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Invite invite = new Invite();
            invite.UserSenderId = _context.UserAccounts.Where(x => x.UserId == id).FirstOrDefault().ProfileId;

            if (bandId != null)
            {
                invite.BandRecipientId = bandId;
            } else if( userId != null)
            {
                invite.UserRecipientId = userId;
            }

            return View(invite);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserCreate(Invite invite)
        {
            return View();
        }

        // GET: Invite/Create
        public ActionResult BandCreate(int bandId, int userId)
        {
            var sender = _context.Bands.Where(x => x.BandId == bandId).FirstOrDefault();
            var user = _context.UserAccounts.Where(x => x.ProfileId == userId).FirstOrDefault();
            Invite invite = new Invite();
            invite.BandSenderId = bandId;
            //invite.Sender = sender;
            invite.UserRecipientId = userId;
            //invite.Recipient = user;
            return View(invite);
        }


        
        // POST: Invite/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BandCreate(Invite invite)
        {
            var addInvite = new Invite();
            addInvite.Message = invite.Message;
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserAccounts.Where(x => x.UserId == id).FirstOrDefault().ProfileId;
            addInvite.BandSenderId = invite.BandSenderId;
            addInvite.UserRecipientId = invite.UserRecipientId;
            
            //invite.SenderId = user;
            //invite.Recipient = (int)ViewData["userId"];
            _context.Invites.Add(addInvite);
            _context.SaveChanges();
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Details(int id)
        {
            var invite = await _context.Invites.Where(x => x.Id == id).FirstOrDefaultAsync();
            return View(invite);
        }

        public async Task<ActionResult> Accept(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault().ProfileId;
            var invite = await _context.Invites.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (invite.UserRecipientId == user)
            {
                AcceptedInvite acceptedInvite = new AcceptedInvite();
                acceptedInvite.UserRecipientId = invite.UserRecipientId;
                acceptedInvite.UserSenderId = invite.UserSenderId;
                await _context.AcceptedInvites.AddAsync(acceptedInvite);
                _context.Invites.Remove(invite);
                await _context.SaveChangesAsync();

                //Which controller should this belong to?
                return RedirectToAction("Conversation", "Message");
            }

            return RedirectToAction("myinvites", "invite");
        }

        public async Task<ActionResult> Decline(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault().ProfileId;
            var invite = await _context.Invites.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (invite.UserRecipientId == user)
            {
                _context.Invites.Remove(invite);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("myinvites", "invite");
        }

        public async Task<ActionResult> MyInvites()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserAccounts.Where(x => x.UserId == id).FirstOrDefault().ProfileId;
            var invites = await _context.Invites.Where(x => x.UserRecipientId == user).ToListAsync();
            foreach( var i in invites )
            {
                if (i.BandSenderId != null)
                {
                    i.BandSender = await _context.Bands.Where(x => x.BandId == i.BandSenderId).FirstOrDefaultAsync();
                }
            }
            return View(invites);
        }
    }
}