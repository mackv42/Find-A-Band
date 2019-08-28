using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FindABand.Data;
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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Messages(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();
            var bandAccount = _context.Bands.Where(x => x.BandId == id).FirstOrDefault();
            var messages = _context.Messages.Where(x => x.SenderId == userAccount.ProfileId || x.RecipientId == userAccount.ProfileId);
            messages = messages.Where(x => x.SenderId == id || x.RecipientId == id);

            return View(messages);
        }
        // GET: Message/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Message/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Message/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Message/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Message/Edit/5
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

        // GET: Message/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Message/Delete/5
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