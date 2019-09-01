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
            var addInvite = new Invite();
            addInvite.Message = invite.Message;
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserAccounts.Where(x => x.UserId == id).FirstOrDefault().ProfileId;
            addInvite.UserSenderId = invite.UserSenderId;
            addInvite.BandRecipientId = invite.BandRecipientId;
            addInvite.UserRecipientId = invite.UserRecipientId;
            _context.Invites.Add(addInvite);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
         
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
            
            _context.Invites.Add(addInvite);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public async Task<ActionResult> Details(int id)
        {
            var invite = await _context.Invites.Where(x => x.Id == id).FirstOrDefaultAsync();
            return View(invite);
        }

        public async Task<ActionResult> Accept(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();
            var invite = await _context.Invites.Where(x => x.Id == id).FirstOrDefaultAsync();
            var bands = await _context.Bands.Where(x => x.UserId == userId).ToListAsync();

            foreach(var band in bands)
            {
                if (invite.BandRecipientId == band.BandId)
                {
                    AcceptedInvite acceptedInvite = new AcceptedInvite();
                    acceptedInvite.UserRecipientId = invite.UserRecipientId;
                    acceptedInvite.UserSenderId = invite.UserSenderId;
                    acceptedInvite.BandRecipientId = band.BandId;
                    //acceptedInvite.BandSenderId = band.Band
                    var message = new Message();
                    message.Text = $"Start Of Conversation with {band.Name} and {user.FirstName}";

                    message.SenderId = user.ProfileId;
                    message.RecipientBandId = band.BandId;
                    await _context.Messages.AddAsync(message);
                    await _context.AcceptedInvites.AddAsync(acceptedInvite);
                    _context.Invites.Remove(invite);
                    await _context.SaveChangesAsync();

                    //Which controller should this belong to?
                    return RedirectToAction("Conversation", "Message");
                }
            }
            if (invite.UserRecipientId == user.ProfileId)
            {
                AcceptedInvite acceptedInvite = new AcceptedInvite();
                acceptedInvite.UserRecipientId = invite.UserRecipientId;
                acceptedInvite.UserSenderId = invite.UserSenderId;
                acceptedInvite.BandSenderId = invite.BandSenderId;

                var message = new Message();
                if (invite.BandSenderId != null)
                {
                    var band = _context.Bands.Where(x => x.BandId == invite.BandSenderId).FirstOrDefault();
                    message.Text = $"Start Of Conversation with {band.Name} and {user.FirstName}";
                }
                else
                {
                    var userSender = _context.UserAccounts.Where(x => x.ProfileId == invite.UserSenderId).FirstOrDefault();
                    message.Text = $"Start Of Conversation with {userSender.FirstName} and {user.FirstName}";
                }

                message.SenderId = user.ProfileId;
                message.SenderBandId = acceptedInvite.BandSenderId;
                message.RecipientBandId = acceptedInvite.BandRecipientId;
                message.RecipientId = acceptedInvite.UserRecipientId;
                await _context.Messages.AddAsync(message);
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
            var myBands = await _context.Bands.Where(x => x.UserId == id).ToListAsync();

            var invites = await _context.Invites.Where(x => x.UserRecipientId == user).ToListAsync();

            foreach(var band in myBands)
            {
                var In = await _context.Invites.Where(x => x.BandRecipientId == band.BandId).ToListAsync();
                foreach(var i in In)
                {
                    invites.Add(i);
                }
            }

            foreach( var i in invites )
            {
                if (i.BandSenderId != null)
                {
                    i.BandSender = await _context.Bands.Where(x => x.BandId == i.BandSenderId).FirstOrDefaultAsync();
                }
            }

            foreach( var i in invites)
            {
                if(i.UserSenderId != null)
                {
                    i.UserSender = await _context.UserAccounts.Where(x => x.ProfileId == i.UserSenderId).FirstOrDefaultAsync();
                }
            }
            return View(invites);
        }
    }
}