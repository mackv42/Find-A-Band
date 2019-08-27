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
            var user = _context.UserAccounts.Where(x => x.ProfileId == userId);
            Invite invite = new Invite();
            invite.Recipient = userId;
            return View(invite);
        }

        // POST: Invite/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Invite invite)
        {
            var addInvite = new Invite();
            addInvite.Message = invite.Message;
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserAccounts.Where(x => x.UserId == id).FirstOrDefault().ProfileId;
            addInvite.SenderId = user;
            addInvite.Recipient = invite.Recipient;
            
            invite.SenderId = user;
            //invite.Recipient = (int)ViewData["userId"];
            await _context.Invites.AddAsync(addInvite);
            await _context.SaveChangesAsync();
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

        public async Task<ActionResult> MyInvites()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserAccounts.Where(x => x.UserId == id).FirstOrDefault().ProfileId;
            var invites = await _context.Invites.Where(x => x.Recipient == user).ToListAsync();
            return View(invites);
        }
    }
}