using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FindABand.Data;
using FindABand.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        // GET: Invite/Details/5
        public ActionResult Details(int id)
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

        // GET: Invite/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Invite/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Invite/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Invite/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}