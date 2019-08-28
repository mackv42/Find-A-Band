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

        // GET: Invite/Create
        public ActionResult Create(int userId)
        {
            var user = _context.UserAccounts.Where(x => x.ProfileId == userId).FirstOrDefault();
            Invite invite = new Invite();
            invite.RecipientId = userId;
            invite.Recipient = user;
            return View(invite);
        }

        // POST: Invite/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Invite invite)
        {
            var addInvite = new Invite();
            addInvite.Message = invite.Message;
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserAccounts.Where(x => x.UserId == id).FirstOrDefault().ProfileId;
            addInvite.SenderId = user;
            addInvite.RecipientId = invite.RecipientId;
            
            invite.SenderId = user;
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

            if (invite.RecipientId == user)
            {
                AcceptedInvite acceptedInvite = new AcceptedInvite();
                acceptedInvite.RecipientId = invite.RecipientId;
                acceptedInvite.SenderId = invite.SenderId;
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

            if (invite.RecipientId == user)
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
            var invites = await _context.Invites.Where(x => x.RecipientId == user).ToListAsync();
            foreach( var i in invites )
            {
                i.Sender = await _context.Bands.Where(x => x.BandId == i.SenderId).FirstOrDefaultAsync();
            }
            return View(invites);
        }
    }
}